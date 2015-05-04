namespace SharkBait
{
    partial class ucString
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbSearchStrings = new System.Windows.Forms.TextBox();
            this.lblBox1 = new System.Windows.Forms.Label();
            this.lbOne = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // tbSearchStrings
            // 
            this.tbSearchStrings.Location = new System.Drawing.Point(125, 4);
            this.tbSearchStrings.Name = "tbSearchStrings";
            this.tbSearchStrings.Size = new System.Drawing.Size(100, 22);
            this.tbSearchStrings.TabIndex = 5;
            // 
            // lblBox1
            // 
            this.lblBox1.AutoSize = true;
            this.lblBox1.Location = new System.Drawing.Point(18, 7);
            this.lblBox1.Name = "lblBox1";
            this.lblBox1.Size = new System.Drawing.Size(101, 17);
            this.lblBox1.TabIndex = 4;
            this.lblBox1.Text = "Search Strings";
            // 
            // lbOne
            // 
            this.lbOne.FormattingEnabled = true;
            this.lbOne.HorizontalScrollbar = true;
            this.lbOne.ItemHeight = 16;
            this.lbOne.Location = new System.Drawing.Point(17, 30);
            this.lbOne.Name = "lbOne";
            this.lbOne.Size = new System.Drawing.Size(417, 580);
            this.lbOne.TabIndex = 3;
            // 
            // ucString
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbSearchStrings);
            this.Controls.Add(this.lblBox1);
            this.Controls.Add(this.lbOne);
            this.Name = "ucString";
            this.Size = new System.Drawing.Size(448, 627);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSearchStrings;
        private System.Windows.Forms.Label lblBox1;
        private System.Windows.Forms.ListBox lbOne;
    }
}
