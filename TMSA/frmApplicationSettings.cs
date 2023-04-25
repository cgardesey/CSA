using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TMSA
{
    public partial class frmApplicationSettings : Form
    {
        public SlightlyMoreSophisticatedDirtyTracker _dirtyTracker;

        public frmApplicationSettings()
        {
            InitializeComponent();
        }

        private void frmApplicationSettings_Load(object sender, EventArgs e)
        {
            tbConString.Text = Properties.Settings.Default.TMSAConnectionString;
            tbCongName.Text = Properties.Settings.Default.CongName;

            _dirtyTracker = new SlightlyMoreSophisticatedDirtyTracker(this);
            _dirtyTracker.MarkAsClean();
        }

        private void frmApplicationSettings_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default["TMSAConnectionString"] = tbConString.Text.ToString();
            Properties.Settings.Default["CongName"] = tbCongName.Text.ToString();

            Properties.Settings.Default.Save();

            Cursor.Current = Cursors.WaitCursor;
            Singleton.applicationSettings = null;
        }

        private void frmApplicationSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_dirtyTracker.IsDirty)
            {
                frmMessageBoxForm messageBox = new frmMessageBoxForm("Close and reopen application to apply changes to application settings?");
                messageBox.yes = false;
                messageBox.no = true;
                messageBox.cancel = true;
                messageBox.ok = false;

                messageBox.btnNo.Text = "Cancel";
                messageBox.btnCancel.Text = "Ok";
                DialogResult result = messageBox.ShowDialog();

                switch (result)
                {
                    case DialogResult.No:
                        // cancel the close
                        e.Cancel = true;
                        break;

                    case DialogResult.Cancel:
                        break;
                }
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
