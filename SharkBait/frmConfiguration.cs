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

namespace SharkBait
{
    public partial class frmConfiguration : Form
    {
        public frmConfiguration()
        {
            InitializeComponent();

            //check boxes that were checked last time
            Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
            cbStrings.Checked = config.AppSettings.Settings["Strings"].Value.ToString() == "True" ? true : false;
            cbListDlls.Checked = config.AppSettings.Settings["List Dlls"].Value.ToString() == "True" ? true : false;
            cbProcMon.Checked = config.AppSettings.Settings["ProcMon"].Value.ToString() == "True" ? true : false;
            cbProcExp.Checked = config.AppSettings.Settings["ProcExp"].Value.ToString() == "True" ? true : false;
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            Configuration config;
            ofd.Title = "Open Binary File";
            ofd.Filter = "EXE Files|*.exe|ELF|*.ELF|AllFiles|*.*";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                lblFileName.Text = ofd.SafeFileName.ToString();
                config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
                config.AppSettings.Settings["FileName"].Value = ofd.SafeFileName.ToString();
                config.Save(ConfigurationSaveMode.Minimal);
            }
        }

        private void EventCheckBoxChecked(object sender, EventArgs e)
        {
            var cbObj = (CheckBox)sender;
            //Save Checked box condiguration to App.config
            Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
            config.AppSettings.Settings[cbObj.Text].Value = cbObj.Checked.ToString();
            config.Save(ConfigurationSaveMode.Minimal);

        }
    }
}
