using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TMSA
{
    public static class Extension
    {
        public static int sqlexception (this Exception ex, String text = "")
        {
            var x = ex;
            var sql2 = ex.GetType();
            var sql = ex.GetBaseException() as SqlException;
            if(sql != null)
            {
                switch (sql.Number)
                {
                    case 2:
                        {
                            frmMessageBoxForm messageBox = new frmMessageBoxForm("Cannot Connect to Server");
                            messageBox.ShowDialog();
                            break;
                        }

                    case 2601:
                        {
                            frmMessageBoxForm messageBox = new frmMessageBoxForm(text + " Already Exists!");
                            messageBox.ShowDialog();
                            //productNameTextBox.Focus();
                            break;
                        }

                    case 547: // Foreign Key violation
                        {
                            frmMessageBoxForm messageBox = new frmMessageBoxForm(" This operation failed because another data entry uses this entry.");
                            messageBox.ShowDialog();
                            break;
                        }                       
                                          
                    default:
                        {
                            frmMessageBoxForm messageBox = new frmMessageBoxForm("Error code: " + sql.Number.ToString() + ". " + sql.Message);
                            messageBox.ShowDialog();
                            break;
                        }
                }
                return sql.Number;
            }
            else if(ex.ToString().Contains("The process cannot access the file"))
            {
                frmMessageBoxForm messageBox = new frmMessageBoxForm(ex.Message);
                messageBox.ShowDialog();
            }
            else
            {
                frmMessageBoxForm messageBox = new frmMessageBoxForm((ex.InnerException != null) ? ex.InnerException.Message : "Error occured");
                messageBox.ShowDialog();
            }
            return 0;
        }        
    }

    public static class Singleton
    {
        public static frmPublishers publishers = null;
        public static frmFSrecords fsrecords = null;
        public static frmFSRreport fsreport = null;
        public static frmPublisherCard publisherCard = null;
        public static frmChoosePublisher choosepublisher = null;
        public static frmFSrecordsImport fsrecordsimport = null;
        public static frmApplicationSettings applicationSettings = null;

        public static void ShowPublishers()
        {
            
            if (publishers != null)
            {
                publishers.BringToFront();
                publishers.WindowState = FormWindowState.Normal;
            }
            else
            {
                publishers = new frmPublishers();
                publishers.Show();
            }
        }

        public static void ShowFSrecord(String id)
        {

            if (fsrecords != null)
            {
                fsrecords.BringToFront();
                fsrecords.focusRow(id);
                fsrecords.WindowState = FormWindowState.Normal;
            }
            else
            {
                fsrecords = new frmFSrecords(id);
                fsrecords.Show();
            }
        }

        public static void ShowFSreport()
        {

            if (fsreport != null)
            {
                fsreport.BringToFront();
                fsreport.WindowState = FormWindowState.Normal;
            }
            else
            {
                fsreport = new frmFSRreport();
                fsreport.Show();
            }
        }

        public static void ShowApplicationSettings()
        {

            if (applicationSettings != null)
            {
                applicationSettings.BringToFront();
                applicationSettings.WindowState = FormWindowState.Normal;
            }
            else
            {
                applicationSettings = new frmApplicationSettings();
                applicationSettings.Show();
            }
        }

        public static void ShowPublisherCard(frmPublishers publishers)
        {

            if (publisherCard != null)
            {
                publisherCard.BringToFront();
                publisherCard.WindowState = FormWindowState.Normal;
            }
            else
            {
                publisherCard = new frmPublisherCard(publishers);
                publisherCard.Show();
            }
       }

        public static void ShowChoosePublisher()
        {

            if (choosepublisher != null)
            {
                choosepublisher.BringToFront();
                choosepublisher.WindowState = FormWindowState.Normal;
            }
            else
            {
                choosepublisher = new frmChoosePublisher();
                choosepublisher.Show();
            }
        }

        public static void ShowFSRimport()
        {
            if (fsrecordsimport != null)
            {
                fsrecordsimport.BringToFront();
                fsrecordsimport.WindowState = FormWindowState.Normal;
            }
            else
            {
                fsrecordsimport = new frmFSrecordsImport();
                fsrecordsimport.Show();
            }
        }
    }
}
