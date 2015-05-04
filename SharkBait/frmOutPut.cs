using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharkBait
{
    public partial class frmOutPut : Form
    {
        frmConfiguration frmConfig;
        public frmOutPut(frmConfiguration _form)
        {
            InitializeComponent();
            this.frmConfig = _form;
            System.IO.StreamReader sr = frmConfig._stream;

            while (!sr.EndOfStream)
            {
                lbOne.Items.Add(sr.ReadLine()); 
            }
            
        }

        private void tbSearchStrings_TextChanged(object sender, EventArgs e)
        {
            int index = lbOne.FindString(tbSearchStrings.Text);
            if (index != -1)
            {
                lbOne.SetSelected(index, true);
            }
            else
            {
                MessageBox.Show("Sorry could not find {0}", tbSearchStrings.Text);
            }
        }


    }
}
