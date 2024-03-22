using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using iTextSharp.text.pdf;
using System.IO;
using System.Collections.Specialized;

namespace TMSA
{
    public partial class frmNewPublisherCard : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        string sqlstr;
        public frmNewPublisherCard()
        {
            InitializeComponent();
        }

        private frmPublishers publishers = null;
        public frmNewPublisherCard(Form callingForm)
        {
            publishers = callingForm as frmPublishers;
            InitializeComponent();
        }

        #region Form Properties
        private const int CS_DROPSHADOW = 0x00020000;

        private bool Dragging = false;
        private Point StartPoint = new Point(0, 0);

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        private void AddSale_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle, Color.Orange, ButtonBorderStyle.Solid);
        }

        private void AddSale_MouseDown(object sender, MouseEventArgs e)
        {
            Dragging = true;
            StartPoint = new Point(e.X, e.Y);
        }
        private void AddSale_MouseMove(object sender, MouseEventArgs e)
        {
            if (Dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.StartPoint.X, p.Y - this.StartPoint.Y);
            }
        }

        private void AddSale_MouseUp(object sender, MouseEventArgs e)
        {
            Dragging = false;
        }
        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            Dragging = true;
            StartPoint = new Point(e.X, e.Y);
        }
        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.StartPoint.X, p.Y - this.StartPoint.Y);
            }
        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            Dragging = false;
        }

        #endregion

        private void btnBackupLocBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                saveLocTextBox.Text = dlg.SelectedPath;
            }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool validated = true;
            if (String.IsNullOrWhiteSpace(saveLocTextBox.Text.ToString()))
            {
                errorProvider1.SetError(saveLocTextBox, "Please set save location.");
                errorProvider1.SetIconPadding(this.saveLocTextBox, 0);

                validated = false;
            }
            if (String.IsNullOrWhiteSpace(sampleCardTextBox.Text.ToString()))
            {
                errorProvider1.SetError(sampleCardTextBox, "Please set empty S-21-E form.");
                errorProvider1.SetIconPadding(this.sampleCardTextBox, 0);
                validated = false;
            }
            if (validated)
            {
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    foreach (DataGridViewRow row in this.publishers.publisherDataGridView.Rows)
                    {
                        if (row != null && row.Cells[0].Value != null && Convert.ToBoolean(row.Cells["active"].Value) == false)
                        {
                            String pdfTemplate = sampleCardTextBox.Text.ToString();

                            String othernames = row.Cells["other_names"].Value == DBNull.Value ? "" : row.Cells["other_names"].Value.ToString().Trim();
                            String lastname = row.Cells["last_name"].Value == DBNull.Value ? "" : row.Cells["last_name"].Value.ToString().Trim();
                            String name = (othernames + " " + lastname).Trim();
                            String superscript = "";
                            if (row.Cells["hour_type"].Value.ToString().Trim() == "Field Missionary")
                            {
                                superscript = "F";
                            }
                            else if (row.Cells["hour_type"].Value.ToString().Trim() == "Special Pioneer")
                            {
                                superscript = "S";
                            }
                            else if (row.Cells["hour_type"].Value.ToString().Trim() == "Regular Pioneer")
                            {
                                superscript = "P";
                            }
                            else if (row.Cells["hour_type"].Value.ToString().Trim() != "Regular Pioneer")
                            {
                                if (!String.IsNullOrWhiteSpace(row.Cells["group"].Value.ToString()))
                                {
                                    superscript = row.Cells["group"].Value.ToString().Trim().Substring(6);
                                }
                            }
                            string newFile = saveLocTextBox.Text.ToString() + @"\" + superscript + " " + name + ".pdf";

                            PdfReader pdfReader = new PdfReader(pdfTemplate);
                            PdfStamper pdfStamper = new PdfStamper(pdfReader, new FileStream(
                                        newFile, FileMode.Create));

                            AcroFields pdfFormFields = pdfStamper.AcroFields;

                            pdfFormFields.SetField("Name", name);
                            if (row.Cells["dob"].Value == DBNull.Value)
                            {
                                pdfFormFields.SetField("900_2_Text_SanSerif", "");
                            }
                            else
                            {
                                DateTime dob = Convert.ToDateTime(row.Cells["dob"].Value.ToString());

                                String formatted_dob = String.Format("{0:MMMM d, yyyy}", dob).ToUpper();  // "January 1, 1753"
                                if (formatted_dob != "January 1, 1753")
                                {
                                    pdfFormFields.SetField("900_2_Text_SanSerif", formatted_dob);
                                }
                            }

                            if (row.Cells["baptisam_date"].Value == DBNull.Value)
                            {
                                pdfFormFields.SetField("900_5_Text_SanSerif", "");
                            }
                            else
                            {
                                DateTime baptism_date = Convert.ToDateTime(row.Cells["baptisam_date"].Value.ToString());
                                String formatted_baptism_date = String.Format("{0:MMMM d, yyyy}", baptism_date).ToUpper();
                                if (formatted_baptism_date != "January 1, 1753")
                                {
                                    pdfFormFields.SetField("900_5_Text_SanSerif", formatted_baptism_date);
                                }
                            }

                            pdfFormFields.SetField("900_3_CheckBox", row.Cells["gender"].Value.ToString().Trim() == "Male" ? "Yes" : "0");
                            pdfFormFields.SetField("900_4_CheckBox", row.Cells["gender"].Value.ToString().Trim() == "Female" ? "Yes" : "0");
                            pdfFormFields.SetField("900_6_CheckBox", row.Cells["hope"].Value.ToString().Trim() == "Other sheep" ? "Yes" : "0");
                            pdfFormFields.SetField("900_7_CheckBox", row.Cells["hope"].Value.ToString().Trim() == "Anointed" ? "Yes" : "0");
                            pdfFormFields.SetField("900_8_CheckBox", row.Cells["privilege"].Value.ToString().Trim() == "Elder" ? "Yes" : "0");
                            pdfFormFields.SetField("900_9_CheckBox", row.Cells["privilege"].Value.ToString().Trim() == "Ministerial Servant" ? "Yes" : "0");
                            pdfFormFields.SetField("900_10_CheckBox", row.Cells["hour_type"].Value.ToString().Trim() == "Regular Pioneer" ? "Yes" : "0");
                            pdfFormFields.SetField("900_11_CheckBox", row.Cells["hour_type"].Value.ToString().Trim() == "Special Pioneer" ? "Yes" : "0");
                            pdfFormFields.SetField("900_12_CheckBox", row.Cells["hour_type"].Value.ToString().Trim() == "Field Missionary" ? "Yes" : "0");
                            int selected_year = Convert.ToInt32(service_yearComboBox.Text);
                            this.publishers.publisher_field_service_report_viewBindingSource.Filter = "publisher_id = " + row.Cells[0].Value + @" AND [report_date] >= '" + selected_year.ToString() + "-09-30' AND [report_date] <= '" + (selected_year + 1) + "-08-31'";
                            double total_h = 0;

                            foreach (DataGridViewRow row2 in this.publishers.publisher_field_service_report_viewDataGridView.Rows)
                            {
                                if (row2.Cells[0].Value != null)
                                {
                                    DateTime datevalue = (Convert.ToDateTime(row2.Cells["_report_date"].Value.ToString()));

                                    if (Convert.ToDateTime(row2.Cells["_report_date"].Value) <= DateTime.Parse("September 30, 2023"))
                                    {
                                        continue;
                                    }

                                    int mnt = datevalue.Month;
                                    String sub = (mnt > 8 ? (mnt + 11) : (mnt + 23)).ToString();
                                    String monthString = getMonthString(mnt);
                                    pdfFormFields.SetField("903_" + sub + "_CheckBox", row2.Cells["_hour_type"].Value.ToString().Trim() == "Auxiliary Pioneer" ? "Yes" : "0");
                                    if (row2.Cells["_shared_in_ministry"].Value == DBNull.Value)
                                    {
                                        pdfFormFields.SetField("901_" + sub + "_CheckBox", "0");
                                    }
                                    else
                                    {
                                        pdfFormFields.SetField("901_" + sub + "_CheckBox", Convert.ToBoolean(row2.Cells["_shared_in_ministry"].Value) == true ? "Yes" : "0");
                                    }
                                    if (row2.Cells["_hours"].Value == DBNull.Value)
                                    {
                                        pdfFormFields.SetField("904_" + sub + "_S21_Value", "");
                                    }
                                    else
                                    {
                                        pdfFormFields.SetField("904_" + sub + "_S21_Value", row2.Cells["_hours"].Value.ToString());
                                        total_h += Convert.ToDouble(row2.Cells["_hours"].Value);
                                    }
                                    if (row2.Cells["_bible_studies"].Value == DBNull.Value)
                                    {
                                        pdfFormFields.SetField("902_" + sub + "_Text_C_SanSerif", "");
                                    }
                                    else
                                    {
                                        pdfFormFields.SetField("902_" + sub + "_Text_C_SanSerif", row2.Cells["_bible_studies"].Value.ToString());
                                    }
                                    if (row2.Cells["_remarks"].Value == DBNull.Value)
                                    {
                                        pdfFormFields.SetField("905_" + sub + "_Text_SanSerif", "");
                                    }
                                    else
                                    {
                                        pdfFormFields.SetField("905_" + sub + "_Text_SanSerif", row2.Cells["_remarks"].Value.ToString());
                                    }
                                }
                            }
                            if (total_h > 0.0)
                            {
                                pdfFormFields.SetField("904_32_S21_Value", total_h.ToString("0.##"));
                            }
                            pdfFormFields.SetField("900_13_Text_C_SanSerif", selected_year.ToString());

                            pdfStamper.FormFlattening = false;

                            // close the pdf
                            pdfStamper.Close();
                        }
                    }
                    if (this.publishers.publisherDataGridView.Rows.Count == 1)
                    {
                        frmMessageBoxForm messageBox = new frmMessageBoxForm("Publisher card saved to location: " + saveLocTextBox.Text.ToString());
                        messageBox.ShowDialog();
                    }
                    else
                    {
                        frmMessageBoxForm messageBox = new frmMessageBoxForm("Publisher cards saved to location: " + saveLocTextBox.Text.ToString());
                        messageBox.ShowDialog();
                    }
                }
                catch (Exception ex)
                {
                    this.Close();
                    ex.sqlexception();
                }
            }
        }

        private string getMonthString(int mnt)
        {
            switch (mnt)
            {
                case 1:
                    return "January";
                case 2:
                    return "February";
                case 3:
                    return "March";
                case 4:
                    return "April";
                case 5:
                    return "May";
                case 6:
                    return "June";
                case 7:
                    return "July";
                case 8:
                    return "August";
                case 9:
                    return "September";
                case 10:
                    return "October";
                case 11:
                    return "November";
                case 12:
                    return "December";
                default:
                    return "";
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label3_MouseUp(object sender, MouseEventArgs e)
        {
            Dragging = false;
        }

        private void label3_MouseDown(object sender, MouseEventArgs e)
        {
            Dragging = true;
            StartPoint = new Point(e.X, e.Y);
        }

        private void label3_MouseMove(object sender, MouseEventArgs e)
        {
            if (Dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.StartPoint.X, p.Y - this.StartPoint.Y);
            }
        }

        private void BackupAndRestore_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle, Color.Orange, ButtonBorderStyle.Solid);
        }

        private void frmBackupAndRestore_Load(object sender, EventArgs e)
        {
            try
            {
                this.getServiceYearsTableAdapter.Fill(this.tMSADataSet.GetServiceYears);
                getServiceYearsBindingSource.Filter = "service_year >= '" + 2023 + "' ";
            }
            catch (Exception ex)
            {
                this.Close();
                ex.sqlexception();
            }
        }

        private void loadServiceYears()
        {
            using (nleEntities db = new nleEntities())
            {
                try
                {
                    getServiceYearsBindingSource.DataSource = db.GetServiceYears().ToList();
                }
                catch (Exception ex)
                {
                    ex.sqlexception();
                }
            }
        }

        private void btnSampleCardBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "All Files(*.*)|*.*|PDF Files(*.pdf)|*.pdf";
            dlg.FilterIndex = 0;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                sampleCardTextBox.Text = dlg.FileName;
            }
        }

        private void frmPublisherCard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Singleton.newPublisherCard = null;
        }

        private void btnGenerateSummaries_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool validated = true;
            if (String.IsNullOrWhiteSpace(saveLocTextBox.Text.ToString()))
            {
                errorProvider1.SetError(saveLocTextBox, "Please set save location.");
                errorProvider1.SetIconPadding(this.saveLocTextBox, 0);

                validated = false;
            }
            if (String.IsNullOrWhiteSpace(sampleCardTextBox.Text.ToString()))
            {
                errorProvider1.SetError(sampleCardTextBox, "Please set empty S-21-E form.");
                errorProvider1.SetIconPadding(this.sampleCardTextBox, 0);
                validated = false;
            }
            if (validated)
            {
                try
                {
                    var arr = new[] { "Field Missionary", "Special Pioneer", "Regular Pioneer", "Auxiliary Pioneer", "Publisher" };

                    NameValueCollection myCol = new NameValueCollection();

                    Cursor.Current = Cursors.WaitCursor;
                    foreach (String str in arr)
                    {
                        String pdfTemplate = sampleCardTextBox.Text.ToString();

                        string newFile = saveLocTextBox.Text.ToString() + @"\" + Properties.Settings.Default.CongName + " (" + str + "s).pdf";

                        PdfReader pdfReader = new PdfReader(pdfTemplate);
                        PdfStamper pdfStamper = new PdfStamper(pdfReader, new FileStream(
                                    newFile, FileMode.Create));

                        AcroFields pdfFormFields = pdfStamper.AcroFields;

                        pdfFormFields.SetField("Name", Properties.Settings.Default.CongName + " (" + str + "s)");

                        int selected_year_summary = Convert.ToInt32(service_yearComboBox.Text);
                        this.publishers.publisher_field_service_report_viewBindingSource.Filter = @"[hour_type] LIKE '%" + str + "%'" + " AND [report_date] >= '" + (selected_year_summary - 1).ToString() + "-09-30' AND [report_date] <= '" + selected_year_summary + "-08-31' AND shared_in_ministry ='True'";

                        foreach (DataGridViewRow row2 in this.publishers.publisher_field_service_report_viewDataGridView.Rows)
                        {
                            if (row2.Cells[0].Value != null)
                            {
                                DateTime datevalue = (Convert.ToDateTime(row2.Cells["_report_date"].Value.ToString()));

                                if (Convert.ToDateTime(row2.Cells["_report_date"].Value) <= DateTime.Parse("September 30, 2023"))
                                {
                                    continue;
                                }
                                int mnt = datevalue.Month;
                                String sub = (mnt > 8 ? (mnt + 11) : (mnt + 23)).ToString();
                                String monthString = getMonthString(mnt);



                                if (row2.Cells["_hours"].Value != DBNull.Value)
                                {
                                    if (pdfFormFields.GetField("904_" + sub + "_S21_Value") == null || pdfFormFields.GetField("904_" + sub + "_S21_Value") == "")
                                    {
                                        pdfFormFields.SetField("904_" + sub + "_S21_Value", "0.00");
                                    }


                                    pdfFormFields.SetField("904_" + sub + "_S21_Value", (Convert.ToDouble(pdfFormFields.GetField("904_" + sub + "_S21_Value")) + Convert.ToDouble(row2.Cells["_hours"].Value.ToString())).ToString());
                                }
                                if (row2.Cells["_bible_studies"].Value != DBNull.Value)
                                {
                                    if (pdfFormFields.GetField("902_" + sub + "_Text_C_SanSerif") == null || pdfFormFields.GetField("902_" + sub + "_Text_C_SanSerif") == "")
                                    {
                                        pdfFormFields.SetField("902_" + sub + "_Text_C_SanSerif", "0");
                                    }
                                    pdfFormFields.SetField("902_" + sub + "_Text_C_SanSerif", (Convert.ToInt32(pdfFormFields.GetField("902_" + sub + "_Text_C_SanSerif")) + Convert.ToInt32(row2.Cells["_bible_studies"].Value.ToString())).ToString());
                                }

                                if (pdfFormFields.GetField("905_" + sub + "_Text_SanSerif") == null || pdfFormFields.GetField("905_" + sub + "_Text_SanSerif") == "")
                                {
                                    pdfFormFields.SetField("905_" + sub + "_Text_SanSerif", "0");
                                }
                                pdfFormFields.SetField("905_" + sub + "_Text_SanSerif", (Convert.ToInt32(pdfFormFields.GetField("905_" + sub + "_Text_SanSerif")) + 1).ToString());

                            }
                        }


                        pdfFormFields.SetField("900_13_Text_C_SanSerif", (selected_year_summary).ToString());

                        pdfStamper.FormFlattening = false;

                        // close the pdf
                        pdfStamper.Close();
                    }
                    if (this.publishers.publisherDataGridView.Rows.Count == 1)
                    {
                        frmMessageBoxForm messageBox = new frmMessageBoxForm("Publisher card saved to location: " + saveLocTextBox.Text.ToString());
                        messageBox.ShowDialog();
                    }
                    else
                    {
                        frmMessageBoxForm messageBox = new frmMessageBoxForm("Publisher cards saved to location: " + saveLocTextBox.Text.ToString());
                        messageBox.ShowDialog();
                    }
                }
                catch (Exception ex)
                {
                    this.Close();
                    ex.sqlexception();
                }
            }
        }
    }
}
