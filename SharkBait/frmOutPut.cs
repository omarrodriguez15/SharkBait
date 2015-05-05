using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Diagnostics;

namespace SharkBait
{
    public partial class frmOutPut : Form
    {
        private frmConfiguration frmConfig;
        private Configuration config;
        private System.IO.StreamReader _stream;

        public frmOutPut(frmConfiguration _form)
        {
            InitializeComponent();
            this.frmConfig = _form;

            //Clear tabs
            tabControl.TabPages.Clear();
            
            config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);

            if (config.AppSettings.Settings["Strings"].Value.ToString() == "True")
            {
                buildStringsTab();
            }
            if (config.AppSettings.Settings["List Dlls"].Value.ToString() == "True")
            {
                
            }
            
            
        }

        private void buildStringsTab()
        {
            
            
            TabPage tp = new TabPage();
            ListBox lbOne = new ListBox();
            tp.Name = "Strings";
            tp.Text = "Strings";
            lblSearchBox.Visible = true;
            tbSearchStrings.Visible = true;

            //Execute Program
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "strings.exe";
            startInfo.Arguments = "\"" + config.AppSettings.Settings["FilePath"].Value + "\"";
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;

            //Get the output stream
            Process proc = Process.Start(startInfo);
            _stream = proc.StandardOutput;

            if (_stream != null)
            {
                while (!_stream.EndOfStream)
                {
                    lbOne.Items.Add(_stream.ReadLine());
                }
                lbOne.Dock = DockStyle.Fill;

                tp.Controls.Add(lbOne);

                tabControl.TabPages.Add(tp); 
            }
            else
            {
                this.Close();
            }
            
        }

        private void tbSearchStrings_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var tab = tabControl.SelectedTab;
                ListBox lb = null;
                
                if (tab.Name == "Strings")
                {
                    lb = (ListBox)tab.Controls[0];
                }

                if (tab != null)
                {
                    int index = lb.FindString(tbSearchStrings.Text);
                    if (index != -1)
                    {
                        lb.SetSelected(index, true);
                    }
                    else
                    {
                        string msg = String.Format("Sorry could not find {0}", tbSearchStrings.Text);
                        MessageBox.Show(msg,"Search Not Found");
                        tbSearchStrings.Text = tbSearchStrings.Text.Remove(tbSearchStrings.Text.ToString().Length - 1);
                        tbSearchStrings.Select(tbSearchStrings.Text.Length, 0);
                    } 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
