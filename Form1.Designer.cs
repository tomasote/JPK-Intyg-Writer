using Image = System.Drawing.Image;

namespace JPK_Intyg_Writer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            checkBox1 = new CheckBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            openFileDialog1 = new OpenFileDialog();
            label4 = new Label();
            button2 = new Button();
            label5 = new Label();
            label6 = new Label();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            label7 = new Label();
            openFileDialog2 = new OpenFileDialog();
            button3 = new Button();
            label8 = new Label();
            label9 = new Label();
            progressBar1 = new ProgressBar();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.Location = new System.Drawing.Point(291, 158);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new System.Drawing.Size(137, 36);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "HF-intyg?";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(-5, -12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(269, 253);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Tai Le", 32F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(270, 40);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(454, 55);
            label1.TabIndex = 2;
            label1.Text = "JPK Intyg Writer V 0.01";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(616, 474);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(113, 15);
            label2.TabIndex = 3;
            label2.Text = "© Tomas Pérez 2023";
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(42, 357);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(101, 41);
            button1.TabIndex = 4;
            button1.Text = "Lägg till";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(12, 339);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(167, 15);
            label3.TabIndex = 5;
            label3.Text = "CSV-fil med info (oförändrad):";
            label3.Click += label3_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(12, 411);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(0, 15);
            label4.TabIndex = 6;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new System.Drawing.Point(416, 332);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(308, 110);
            button2.TabIndex = 7;
            button2.Text = "Återskapa magi!";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(500, 272);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(0, 15);
            label5.TabIndex = 8;
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(242, 339);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(126, 15);
            label6.TabIndex = 9;
            label6.Text = "Program du var FK för:";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "B", "BAS", "DV", "E", "Ei", "ES", "F", "I", "IT", "K", "M", "MT", "Q", "STS", "W", "X" });
            comboBox1.Location = new System.Drawing.Point(242, 357);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(121, 23);
            comboBox1.TabIndex = 10;
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(500, 171);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(202, 23);
            textBox1.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(500, 153);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(106, 15);
            label7.TabIndex = 12;
            label7.Text = "Fullständigt namn:";
            // 
            // openFileDialog2
            // 
            openFileDialog2.FileName = "openFileDialog2";
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(500, 228);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(202, 43);
            button3.TabIndex = 13;
            button3.Text = "Lägg till";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(500, 210);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(198, 15);
            label8.TabIndex = 14;
            label8.Text = "PNG-Fil som innehåller din signatur:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(428, 298);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(0, 15);
            label9.TabIndex = 15;
            // 
            // progressBar1
            // 
            progressBar1.Location = new System.Drawing.Point(12, 448);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new System.Drawing.Size(712, 23);
            progressBar1.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(741, 498);
            Controls.Add(progressBar1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(button3);
            Controls.Add(label7);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(checkBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "JPK Intyg Writer";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBox1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Button button1;
        private Label label3;
        private OpenFileDialog openFileDialog1;
        private Label label4;
        private bool isChecked;
        private bool isCheckedSign;
        private Button button2;
        private Label label5;
        private Label label6;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Label label7;
        private OpenFileDialog openFileDialog2;
        private Button button3;
        private Label label8;
        private Label label9;
        private ProgressBar progressBar1;
    }
}