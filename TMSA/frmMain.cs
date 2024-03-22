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
    public partial class frmMain : Form
    {
        string save_msg = "";
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnPublishers_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Singleton.ShowPublishers();
        }

        private void btnFSR_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Singleton.ShowFSrecord(null);
        }

        private void btnFSreport_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Singleton.ShowFSreport();
        }

        private void btnFSRimport_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Singleton.ShowFSRimport();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            // upon closing, check if the form is dirty; if so, prompt
            // to save changes
            if (!changesSaved())
            {
                frmMessageBoxForm messageBox = new frmMessageBoxForm(save_msg);
                messageBox.yes = true;
                messageBox.no = true;
                messageBox.cancel = true;
                messageBox.ok = false;
                DialogResult result = messageBox.ShowDialog();

                switch (result)
                {
                    case DialogResult.Yes:
                        Cursor.Current = Cursors.WaitCursor;
                        if (Singleton.publishers != null)
                        {
                            Singleton.publishers.SaveDocument(); 
                        }    
                        if (Singleton.fsrecords != null)
                        {
                            Singleton.fsrecords.SaveDocument();
                        }
                        
                        break;

                    case DialogResult.No:
                        // just allow the form to close
                        // without saving
                        break;

                    case DialogResult.Cancel:
                        // cancel the close
                        e.Cancel = true;
                        break;
                }
            }
        }

        private bool changesSaved()
        {
            bool saved = true;
            save_msg = "Save changes to the following items?";
            if (Singleton.publishers != null && !Singleton.publishers.saved())
            {
                saved = false;
                save_msg += "\nPublishers*";
            }  
            if (Singleton.fsrecords != null && ! Singleton.fsrecords.saved())
            {
                saved = false;
                save_msg += "\nField Service Report*";
            }
            return saved;
        }

        private void btnPublishers_MouseLeave(object sender, EventArgs e)
        {
            btnPublishers.ForeColor = Color.Black;
        }

        private void btnPublishers_MouseEnter(object sender, EventArgs e)
        {
            btnPublishers.ForeColor = Color.White;
        }

        private void btnFSrecord_MouseEnter(object sender, EventArgs e)
        {
            btnFSrecord.ForeColor = Color.White;
        }

        private void btnFSrecord_MouseLeave(object sender, EventArgs e)
        {
            btnFSrecord.ForeColor = Color.Black;
        }

        private void btnFSreport_MouseEnter(object sender, EventArgs e)
        {
            btnFSreport.ForeColor = Color.White;
        }

        private void btnFSreport_MouseLeave(object sender, EventArgs e)
        {
            btnFSreport.ForeColor = Color.Black;
        }

        private void btnFSrecordsImport_MouseEnter(object sender, EventArgs e)
        {
            btnFSreport.ForeColor = Color.White;
        }

        private void btnFSrecordsImport_MouseEnter_1(object sender, EventArgs e)
        {
            btnFSrecordsImport.ForeColor = Color.White;
        }

        private void btnFSrecordsImport_MouseLeave(object sender, EventArgs e)
        {
            btnFSrecordsImport.ForeColor = Color.Black;
        }

        private void btnApplicationSettings_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Singleton.ShowApplicationSettings();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblCongName.Text = Properties.Settings.Default.CongName;
        }

        private void btnNewFSrecordsImport_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Singleton.ShowNewFSRimport();
        }
    }
}
