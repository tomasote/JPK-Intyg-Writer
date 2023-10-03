
using IronXL;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms.ComponentModel.Com2Interop;
using Word = Microsoft.Office.Interop.Word;
using Application = Microsoft.Office.Interop.Word.Application;
using System.Reflection;
using System;
using Aspose.Words.Replacing;
using System.Reflection.Metadata;
using Document =  Aspose.Words.Document;
using System.Text;
using Microsoft.Office.Interop.Word;

public class CSVReader
{
	private string file_name;
	private string sign_file;
    string f_dir= "C:\\TDB23\\Fadderintyg";
    string hf_dir = "C:\\TDB23\\HF-intyg";
    string fk_name;
    string fk_section;
    ProgressBar pBar;

    List<string> names = new List<string>();
    List<string> ssns = new List<string>();
    List<string> sections = new List<string>();
    private bool hf;

    public CSVReader(string file_name, bool hf, string sign_file, string fk_name, string fk_section, ProgressBar pbar)
	{
		this.file_name = file_name;
		this.hf = hf;
		this.sign_file = sign_file;
        this.fk_name = fk_name;
        this.fk_section = fk_section;
        this.pBar = pbar;
        pbar.Minimum = 0;
        
	}
	public void addNamesAndSSNs()
	{
        WorkBook wb = new WorkBook(@file_name);
		int page = hf ? 0 : 1;
		WorkSheet ws = wb.WorkSheets[page];
		var rows = ws.Rows;
        for (var row = 2; row < rows.Count(); row++ )
		{
            var cells = ws[$"B{row}:E{row}"].ToArray();
            if (cells[0].ToString() != "Ja" || cells[3].ToString() != fk_section)
			{
				continue;
			}
			string? name = cells[1].ToString();
            string? ssn = cells[2].ToString();
            string? section = cells[3].ToString();
			names.Add(name);
			ssns.Add(SSNFormatter(ssn));
			sections.Add(section);
        }
		bool test = names.Count == ssns.Count && names.Count == sections.Count;

        //MessageBox.Show(test.ToString());
    }

    private string SSNFormatter(string ssn)
    {
        if (ssn.Contains('-'))
        {
            ssn.Remove(ssn.IndexOf('-'));
        }
        
        StringBuilder sb = new StringBuilder(ssn);
        if (ssn.Length == 12)
        {
            sb.Insert(8, "-");
            return sb.ToString();
        }
        else if (ssn.Length == 10) {

            switch (ssn[0]) {
                case '0':
                    {
                        sb.Insert(0, '0');
                        sb.Insert(0, '2');
                        sb.Insert(8, "-");
                        return  "(" + sb.ToString() + ")" ;
                    }
                default: 
                    {
                        sb.Insert(0, '9');
                        sb.Insert(0, '1');
                        sb.Insert(8, "-");
                        return "(" + sb.ToString() +")";
                    }

            }
        }
        else { return ""; }
        
    }
	public void changeTextInWord()
	{
		string fname_temp = "XXFNLNXX";
		string ssn_temp = "XXSSNXX";
        string section_temp = "XXSECXX";
		string fkname_temp = "XXYNXX";
        List<string> replace_params = new List<string>
        {
            fname_temp,
            ssn_temp,
            section_temp,
            fkname_temp
        };
        string template_path = hf ? @"C:\TDB23\JPK Intyg Writer\mallHF.docx" : @"C:\TDB23\JPK Intyg Writer\mallF.docx";

        this.pBar.Maximum = sections.Count;
        for (int i = 0; i < sections.Count; i++)
        {
            string local_path = $"\\{sections[i]}\\{names[i]}.docx";
            string fileName = this.hf ? $"{this.hf_dir + local_path}" : @$"{this.f_dir + local_path}";
            string name = names[i];
            /*while(name.Last() == ' ')
            {
                name.Substring(0, name.Length - 1);
            }*/
            List<string> replace_with = new List<string>
            {
                name,
                ssns[i],
                sections[i],
                fk_name
            };

            CreateWordDocument(template_path, fileName, replace_params, replace_with);
            pBar.Value++;
        }
        
    }
    public void exportPDF()
    {
    }
    public void signPDF(string filename)
    {
		int pageLoc = 0; // might change


        PdfDocument document = PdfReader.Open(@filename, PdfDocumentOpenMode.Import);
        PdfDocument PDFNewDoc = new PdfDocument();

        for (int Pg = 0; Pg < document.Pages.Count; Pg++)
        {
            PdfPage page = PDFNewDoc.AddPage(document.Pages[Pg]); 

            if(Pg == pageLoc)
			{
                XGraphics gfx = XGraphics.FromPdfPage(page);
                int height = hf ? 720 : 700;
                DrawImage(gfx, sign_file, 60, height, 180, 50); //Experiment with numbers
            }
        }

        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        // Save and start View
        PDFNewDoc.Save(filename);
        //Process.Start(filename);
    }
    private void FindAndReplace(Microsoft.Office.Interop.Word.Application wordApp, object toFindText, object replaceWithText)
    {
        object matchCase = true;

        object matchwholeWord = true;

        object matchwildCards = false;

        object matchSoundLike = false;

        object nmatchAllforms = false;

        object forward = true;

        object format = false;

        object matchKashida = false;

        object matchDiactitics = false;

        object matchAlefHamza = false;

        object matchControl = false;

        object read_only = false;

        object visible = true;

        object replace = 2;

        object wrap = 1;

        wordApp.Selection.Find.Execute(ref toFindText, ref matchCase,
                                        ref matchwholeWord, ref matchwildCards, ref matchSoundLike,

                                        ref nmatchAllforms, ref forward,

                                        ref wrap, ref format, ref replaceWithText,

                                            ref replace, ref matchKashida,

                                        ref matchDiactitics, ref matchAlefHamza,

                                         ref matchControl);
    }
    private void CreateWordDocument(object filename, object SaveAs, List<string> replace_params, List<string> replace_with)
    {
        string fname_temp = "XXFNLNXX";
        string ssn_temp = "XXSSNXX";
        string section_temp = "XXSECXX";
        string fkname_temp = "XXYNXX";
        Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
        object missing = Missing.Value;

        Microsoft.Office.Interop.Word.Document myWordDoc = null;

        if (File.Exists((string)filename))
        {
            object readOnly = false;

            object AddToRecentFiles = false;

            object isvisible = false;

            wordApp.Visible = false;
            try
            {
                string path = hf ? hf_dir + "\\" +  replace_with[2] : f_dir + "\\" + replace_with[2];
                System.IO.Directory.CreateDirectory(path);
                File.Copy((string)@filename, (string)@SaveAs, true);
            }
            catch (IOException iox)
            {
                //MessageBox.Show(replace_with[2]);
                Console.WriteLine(iox.Message);
            }
            myWordDoc = wordApp.Documents.Open(ref SaveAs, ref missing, ref readOnly,
                                                ref AddToRecentFiles, ref missing, ref missing,
                                                ref missing, ref missing, ref missing,
                                                ref missing, ref missing, ref missing,
                                                 ref missing, ref missing, ref missing, ref missing);
            myWordDoc.Activate();
            for (int i = 0; i < replace_params.Count; i++)
            {
                this.FindAndReplace(wordApp, replace_params[i], replace_with[i]);
            }
            //this.FindAndReplace(wordApp, "Example", "Anything");
            object NoPrompt = true;
            object OriginalFormat = 1;
            WdExportFormat expFormat = WdExportFormat.wdExportFormatPDF;
            string fileAsDOCX = SaveAs.ToString();
            string fileAsPDF = fileAsDOCX.Substring(0, fileAsDOCX.Length - 4) + "pdf";
            myWordDoc.Save();
            myWordDoc.ExportAsFixedFormat(fileAsPDF, expFormat);
            myWordDoc.Close();
            wordApp.Quit();
            signPDF(fileAsPDF);
        }
    }
        void DrawImage(XGraphics gfx, string jpegSamplePath, int x, int y, int width, int height)
    {
        XImage image = XImage.FromFile(jpegSamplePath);
        gfx.DrawImage(image, x, y, width, height);
    }
}
