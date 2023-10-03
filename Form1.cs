

using System.Runtime.CompilerServices;

namespace JPK_Intyg_Writer
{
    public partial class Form1 : Form
    {
        CSVReader? reader;
        bool hf = false;
        bool hasName;
        string file;
        string sign_file;
        bool hasSection;
        public Form1()
        {
            InitializeComponent();
            this.isChecked = false;
            hasName = false;
            hasSection = false;
            this.isCheckedSign = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            hf = checkBox1.Checked ? true : false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int size = -1;
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                try
                {
                    string text = File.ReadAllText(file);
                    size = text.Length;
                    this.file = file;
                }
                catch (IOException)
                {
                }
                Console.WriteLine(size); // <-- Shows file size in debugging mode.
                Console.WriteLine(result); // <-- For debugging use.
                this.label4.Text = file;
                this.isChecked = true;

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string selected = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);
            string name = this.textBox1.Text;
            if (!this.isChecked || name == "" || selected == "" || !this.isCheckedSign)
            {
                MessageBox.Show("Du måste välja en giltig fil och fylla i all info!");
            }
            else
            {
                this.reader = new CSVReader(this.file, hf, sign_file, name, selected, progressBar1);
                reader.addNamesAndSSNs();
                reader.changeTextInWord();

                progressBar1.Value = 0;
                MessageBox.Show("Magi återskapad", "Status");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int size = -1;
            DialogResult result = openFileDialog2.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog2.FileName;
                try
                {
                    string text = File.ReadAllText(file);
                    size = text.Length;
                    this.sign_file = file;
                }
                catch (IOException)
                {
                }
                Console.WriteLine(size); // <-- Shows file size in debugging mode.
                Console.WriteLine(result); // <-- For debugging use.
                this.label9.Text = file;
                this.isCheckedSign = true;

            }

        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

    }
}