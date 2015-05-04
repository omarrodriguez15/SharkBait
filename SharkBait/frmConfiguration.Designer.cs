namespace SharkBait
{
    partial class frmConfiguration
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
            this.cbStrings = new System.Windows.Forms.CheckBox();
            this.cbListDlls = new System.Windows.Forms.CheckBox();
            this.cbProcExp = new System.Windows.Forms.CheckBox();
            this.cbProcMon = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnChooseFile = new System.Windows.Forms.Button();
            this.lblFileName = new System.Windows.Forms.Label();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // cbStrings
            // 
            this.cbStrings.AutoSize = true;
            this.cbStrings.Location = new System.Drawing.Point(46, 175);
            this.cbStrings.Name = "cbStrings";
            this.cbStrings.Size = new System.Drawing.Size(74, 21);
            this.cbStrings.TabIndex = 0;
            this.cbStrings.Text = "Strings";
            this.cbStrings.UseVisualStyleBackColor = true;
            this.cbStrings.CheckedChanged += new System.EventHandler(this.EventCheckBoxChecked);
            // 
            // cbListDlls
            // 
            this.cbListDlls.AutoSize = true;
            this.cbListDlls.Location = new System.Drawing.Point(46, 202);
            this.cbListDlls.Name = "cbListDlls";
            this.cbListDlls.Size = new System.Drawing.Size(79, 21);
            this.cbListDlls.TabIndex = 1;
            this.cbListDlls.Text = "List Dlls";
            this.cbListDlls.UseVisualStyleBackColor = true;
            this.cbListDlls.CheckedChanged += new System.EventHandler(this.EventCheckBoxChecked);
            // 
            // cbProcExp
            // 
            this.cbProcExp.AutoSize = true;
            this.cbProcExp.Location = new System.Drawing.Point(46, 256);
            this.cbProcExp.Name = "cbProcExp";
            this.cbProcExp.Size = new System.Drawing.Size(82, 21);
            this.cbProcExp.TabIndex = 3;
            this.cbProcExp.Text = "ProcExp";
            this.cbProcExp.UseVisualStyleBackColor = true;
            this.cbProcExp.CheckedChanged += new System.EventHandler(this.EventCheckBoxChecked);
            // 
            // cbProcMon
            // 
            this.cbProcMon.AutoSize = true;
            this.cbProcMon.Location = new System.Drawing.Point(46, 229);
            this.cbProcMon.Name = "cbProcMon";
            this.cbProcMon.Size = new System.Drawing.Size(86, 21);
            this.cbProcMon.TabIndex = 2;
            this.cbProcMon.Text = "ProcMon";
            this.cbProcMon.UseVisualStyleBackColor = true;
            this.cbProcMon.CheckedChanged += new System.EventHandler(this.EventCheckBoxChecked);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(299, 175);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(50, 21);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "n/a";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.EventCheckBoxChecked);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(299, 202);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(50, 21);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.Text = "n/a";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.EventCheckBoxChecked);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(299, 256);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(50, 21);
            this.checkBox3.TabIndex = 7;
            this.checkBox3.Text = "n/a";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.EventCheckBoxChecked);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(299, 229);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(50, 21);
            this.checkBox4.TabIndex = 6;
            this.checkBox4.Text = "n/a";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.EventCheckBoxChecked);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(23, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(348, 25);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "Choose a file to run selected utilities on\r\n";
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.Location = new System.Drawing.Point(274, 120);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(97, 23);
            this.btnChooseFile.TabIndex = 9;
            this.btnChooseFile.Text = "Choose File";
            this.btnChooseFile.UseVisualStyleBackColor = true;
            this.btnChooseFile.Click += new System.EventHandler(this.btnChooseFile_Click);
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(12, 120);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(87, 17);
            this.lblFileName.TabIndex = 10;
            this.lblFileName.Text = "Example.exe";
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // frmConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 327);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.btnChooseFile);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.cbProcExp);
            this.Controls.Add(this.cbProcMon);
            this.Controls.Add(this.cbListDlls);
            this.Controls.Add(this.cbStrings);
            this.Name = "frmConfiguration";
            this.Text = "Configuration Panel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbStrings;
        private System.Windows.Forms.CheckBox cbListDlls;
        private System.Windows.Forms.CheckBox cbProcExp;
        private System.Windows.Forms.CheckBox cbProcMon;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnChooseFile;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.OpenFileDialog ofd;
    }
}

