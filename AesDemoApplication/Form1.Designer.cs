namespace AesDemoApplication
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.time = new System.Windows.Forms.Label();
            this.saveFile = new System.Windows.Forms.Button();
            this.ciphBox = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.invCipher = new System.Windows.Forms.Button();
            this.ciphButton = new System.Windows.Forms.Button();
            this.CFBradioButton = new System.Windows.Forms.RadioButton();
            this.CBCradioButton = new System.Windows.Forms.RadioButton();
            this.ECBradioButton = new System.Windows.Forms.RadioButton();
            this.openFile = new System.Windows.Forms.Button();
            this.dataGroupBox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.vectorTextBox = new System.Windows.Forms.TextBox();
            this.keyTextBox = new System.Windows.Forms.TextBox();
            this.genVector = new System.Windows.Forms.Button();
            this.genKey = new System.Windows.Forms.Button();
            this.OFBRadioButton = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.ciphBox.SuspendLayout();
            this.dataGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.time);
            this.panel1.Controls.Add(this.saveFile);
            this.panel1.Controls.Add(this.ciphBox);
            this.panel1.Controls.Add(this.dataGroupBox);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(486, 326);
            this.panel1.TabIndex = 0;
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Location = new System.Drawing.Point(295, 290);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(96, 13);
            this.time.TabIndex = 3;
            this.time.Text = "Time of procedure:";
            // 
            // saveFile
            // 
            this.saveFile.Location = new System.Drawing.Point(6, 285);
            this.saveFile.Name = "saveFile";
            this.saveFile.Size = new System.Drawing.Size(75, 23);
            this.saveFile.TabIndex = 2;
            this.saveFile.Text = "Save File";
            this.saveFile.UseVisualStyleBackColor = true;
            this.saveFile.Click += new System.EventHandler(this.saveFile_Click);
            // 
            // ciphBox
            // 
            this.ciphBox.Controls.Add(this.OFBRadioButton);
            this.ciphBox.Controls.Add(this.textBox1);
            this.ciphBox.Controls.Add(this.label1);
            this.ciphBox.Controls.Add(this.invCipher);
            this.ciphBox.Controls.Add(this.ciphButton);
            this.ciphBox.Controls.Add(this.CFBradioButton);
            this.ciphBox.Controls.Add(this.CBCradioButton);
            this.ciphBox.Controls.Add(this.ECBradioButton);
            this.ciphBox.Controls.Add(this.openFile);
            this.ciphBox.Location = new System.Drawing.Point(0, 127);
            this.ciphBox.Name = "ciphBox";
            this.ciphBox.Size = new System.Drawing.Size(480, 152);
            this.ciphBox.TabIndex = 1;
            this.ciphBox.TabStop = false;
            this.ciphBox.Text = "Cipher Box";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(108, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(166, 20);
            this.textBox1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "MODES";
            // 
            // invCipher
            // 
            this.invCipher.Location = new System.Drawing.Point(122, 88);
            this.invCipher.Name = "invCipher";
            this.invCipher.Size = new System.Drawing.Size(75, 23);
            this.invCipher.TabIndex = 5;
            this.invCipher.Text = "DeCipher";
            this.invCipher.UseVisualStyleBackColor = true;
            this.invCipher.Click += new System.EventHandler(this.invCipher_Click);
            // 
            // ciphButton
            // 
            this.ciphButton.Location = new System.Drawing.Point(6, 88);
            this.ciphButton.Name = "ciphButton";
            this.ciphButton.Size = new System.Drawing.Size(75, 23);
            this.ciphButton.TabIndex = 4;
            this.ciphButton.Text = "Cipher";
            this.ciphButton.UseVisualStyleBackColor = true;
            this.ciphButton.Click += new System.EventHandler(this.ciphButton_Click);
            // 
            // CFBradioButton
            // 
            this.CFBradioButton.AutoSize = true;
            this.CFBradioButton.Location = new System.Drawing.Point(282, 52);
            this.CFBradioButton.Name = "CFBradioButton";
            this.CFBradioButton.Size = new System.Drawing.Size(45, 17);
            this.CFBradioButton.TabIndex = 3;
            this.CFBradioButton.TabStop = true;
            this.CFBradioButton.Text = "CFB";
            this.CFBradioButton.UseVisualStyleBackColor = true;
            // 
            // CBCradioButton
            // 
            this.CBCradioButton.AutoSize = true;
            this.CBCradioButton.Location = new System.Drawing.Point(198, 52);
            this.CBCradioButton.Name = "CBCradioButton";
            this.CBCradioButton.Size = new System.Drawing.Size(46, 17);
            this.CBCradioButton.TabIndex = 2;
            this.CBCradioButton.TabStop = true;
            this.CBCradioButton.Text = "CBC";
            this.CBCradioButton.UseVisualStyleBackColor = true;
            // 
            // ECBradioButton
            // 
            this.ECBradioButton.AutoSize = true;
            this.ECBradioButton.Location = new System.Drawing.Point(108, 52);
            this.ECBradioButton.Name = "ECBradioButton";
            this.ECBradioButton.Size = new System.Drawing.Size(46, 17);
            this.ECBradioButton.TabIndex = 1;
            this.ECBradioButton.TabStop = true;
            this.ECBradioButton.Text = "ECB";
            this.ECBradioButton.UseVisualStyleBackColor = true;
            // 
            // openFile
            // 
            this.openFile.Location = new System.Drawing.Point(6, 19);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(75, 23);
            this.openFile.TabIndex = 0;
            this.openFile.Text = "Open File";
            this.openFile.UseVisualStyleBackColor = true;
            this.openFile.Click += new System.EventHandler(this.openFile_Click);
            // 
            // dataGroupBox
            // 
            this.dataGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGroupBox.Controls.Add(this.label3);
            this.dataGroupBox.Controls.Add(this.label2);
            this.dataGroupBox.Controls.Add(this.vectorTextBox);
            this.dataGroupBox.Controls.Add(this.keyTextBox);
            this.dataGroupBox.Controls.Add(this.genVector);
            this.dataGroupBox.Controls.Add(this.genKey);
            this.dataGroupBox.Location = new System.Drawing.Point(0, 0);
            this.dataGroupBox.Name = "dataGroupBox";
            this.dataGroupBox.Size = new System.Drawing.Size(483, 121);
            this.dataGroupBox.TabIndex = 0;
            this.dataGroupBox.TabStop = false;
            this.dataGroupBox.Text = "Cipher Key & Vector";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Vector";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Key";
            // 
            // vectorTextBox
            // 
            this.vectorTextBox.Location = new System.Drawing.Point(71, 65);
            this.vectorTextBox.Name = "vectorTextBox";
            this.vectorTextBox.Size = new System.Drawing.Size(256, 20);
            this.vectorTextBox.TabIndex = 3;
            this.vectorTextBox.TextChanged += new System.EventHandler(this.vectorTextBox_TextChanged);
            // 
            // keyTextBox
            // 
            this.keyTextBox.Location = new System.Drawing.Point(71, 25);
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.Size = new System.Drawing.Size(256, 20);
            this.keyTextBox.TabIndex = 2;
            this.keyTextBox.TextChanged += new System.EventHandler(this.keyTextBox_TextChanged);
            // 
            // genVector
            // 
            this.genVector.Location = new System.Drawing.Point(359, 63);
            this.genVector.Name = "genVector";
            this.genVector.Size = new System.Drawing.Size(96, 23);
            this.genVector.TabIndex = 1;
            this.genVector.Text = "Generate Vector";
            this.genVector.UseVisualStyleBackColor = true;
            this.genVector.Click += new System.EventHandler(this.genVector_Click);
            // 
            // genKey
            // 
            this.genKey.Location = new System.Drawing.Point(359, 19);
            this.genKey.Name = "genKey";
            this.genKey.Size = new System.Drawing.Size(96, 23);
            this.genKey.TabIndex = 0;
            this.genKey.Text = "Generate Key";
            this.genKey.UseVisualStyleBackColor = true;
            this.genKey.Click += new System.EventHandler(this.genKey_Click);
            // 
            // OFBRadioButton
            // 
            this.OFBRadioButton.AutoSize = true;
            this.OFBRadioButton.Location = new System.Drawing.Point(359, 52);
            this.OFBRadioButton.Name = "OFBRadioButton";
            this.OFBRadioButton.Size = new System.Drawing.Size(46, 17);
            this.OFBRadioButton.TabIndex = 8;
            this.OFBRadioButton.TabStop = true;
            this.OFBRadioButton.Text = "OFB";
            this.OFBRadioButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 350);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "AesDemo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ciphBox.ResumeLayout(false);
            this.ciphBox.PerformLayout();
            this.dataGroupBox.ResumeLayout(false);
            this.dataGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Button saveFile;
        private System.Windows.Forms.GroupBox ciphBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button invCipher;
        private System.Windows.Forms.Button ciphButton;
        private System.Windows.Forms.RadioButton CFBradioButton;
        private System.Windows.Forms.RadioButton CBCradioButton;
        private System.Windows.Forms.RadioButton ECBradioButton;
        private System.Windows.Forms.Button openFile;
        private System.Windows.Forms.GroupBox dataGroupBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox vectorTextBox;
        private System.Windows.Forms.TextBox keyTextBox;
        private System.Windows.Forms.Button genVector;
        private System.Windows.Forms.Button genKey;
        private System.Windows.Forms.RadioButton OFBRadioButton;
    }
}

