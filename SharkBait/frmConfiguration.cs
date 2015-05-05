using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace SharkBait
{
    public partial class frmConfiguration : Form
    {
        private Configuration config;
        public System.IO.StreamReader _stream { get; private set; } 

        public frmConfiguration()
        {
            InitializeComponent();

            try
            {
                //check boxes that were checked last time
                config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
                cbStrings.Checked = config.AppSettings.Settings["Strings"].Value.ToString() == "True" ? true : false;
                cbListDlls.Checked = config.AppSettings.Settings["List Dlls"].Value.ToString() == "True" ? true : false;
                cbProcMon.Checked = config.AppSettings.Settings["ProcMon"].Value.ToString() == "True" ? true : false;
                cbProcExp.Checked = config.AppSettings.Settings["ProcExp"].Value.ToString() == "True" ? true : false;

                if (File.Exists(config.AppSettings.Settings["FilePath"].Value))
                {
                    lblFileName.Text = config.AppSettings.Settings["FileName"].Value.ToString();
                }
            }
            catch (Exception ei)
            {
                MessageBox.Show(ei.Message);
            }
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            ofd.Title = "Open Binary File";
            ofd.Filter = "EXE Files|*.exe|ELF|*.ELF|AllFiles|*.*";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                lblFileName.Text = ofd.SafeFileName.ToString();
                config.AppSettings.Settings["FileName"].Value = ofd.SafeFileName;
                config.AppSettings.Settings["FilePath"].Value = ofd.FileName;
                config.Save(ConfigurationSaveMode.Minimal);
            }
        }

        private void EventCheckBoxChecked(object sender, EventArgs e)
        {
            var cbObj = (CheckBox)sender;
            //Save Checked box condiguration to App.config
            config.AppSettings.Settings[cbObj.Text].Value = cbObj.Checked.ToString();
            config.Save(ConfigurationSaveMode.Minimal);

        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            try
            {
                

                //Show Ouput in our own form
                this.Hide();
                frmOutPut fop = new frmOutPut(this);
                fop.ShowDialog();
                this.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
