namespace SharkBait
{
    partial class frmOutPut
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
            this.components = new System.ComponentModel.Container();
            this.lbOne = new System.Windows.Forms.ListBox();
            this.lblBox1 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbSearchStrings = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbOne
            // 
            this.lbOne.FormattingEnabled = true;
            this.lbOne.HorizontalScrollbar = true;
            this.lbOne.ItemHeight = 16;
            this.lbOne.Location = new System.Drawing.Point(12, 55);
            this.lbOne.Name = "lbOne";
            this.lbOne.Size = new System.Drawing.Size(417, 580);
            this.lbOne.TabIndex = 0;
            // 
            // lblBox1
            // 
            this.lblBox1.AutoSize = true;
            this.lblBox1.Location = new System.Drawing.Point(13, 32);
            this.lblBox1.Name = "lblBox1";
            this.lblBox1.Size = new System.Drawing.Size(101, 17);
            this.lblBox1.TabIndex = 1;
            this.lblBox1.Text = "Search Strings";
            // 
            // tbSearchStrings
            // 
            this.tbSearchStrings.Location = new System.Drawing.Point(120, 29);
            this.tbSearchStrings.Name = "tbSearchStrings";
            this.tbSearchStrings.Size = new System.Drawing.Size(100, 22);
            this.tbSearchStrings.TabIndex = 2;
            this.tbSearchStrings.TextChanged += new System.EventHandler(this.tbSearchStrings_TextChanged);
            // 
            // frmOutPut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 706);
            this.Controls.Add(this.tbSearchStrings);
            this.Controls.Add(this.lblBox1);
            this.Controls.Add(this.lbOne);
            this.Name = "frmOutPut";
            this.Text = "Output";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbOne;
        private System.Windows.Forms.Label lblBox1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox tbSearchStrings;
    }
}