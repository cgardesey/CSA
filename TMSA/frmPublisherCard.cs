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
    public partial class frmPublisherCard : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        string sqlstr;
        public frmPublisherCard()
        {
            InitializeComponent();
        }

        private frmPublishers publishers = null;
        public frmPublisherCard(Form callingForm)
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
                            if (row.Cells["hour_type"].Value.ToString().Trim() == "Regular Pioneer")
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
                                pdfFormFields.SetField("Date of birth", "");
                            }
                            else
                            {
                                DateTime dob = Convert.ToDateTime(row.Cells["dob"].Value.ToString());

                                String formatted_dob = String.Format("{0:MMMM d, yyyy}", dob).ToUpper();  // "January 1, 1753"
                                if (formatted_dob != "January 1, 1753")
                                {
                                    pdfFormFields.SetField("Date of birth", formatted_dob);
                                }
                            }

                            if (row.Cells["baptisam_date"].Value == DBNull.Value)
                            {
                                pdfFormFields.SetField("Date immersed", "");
                            }
                            else
                            {
                                DateTime baptism_date = Convert.ToDateTime(row.Cells["baptisam_date"].Value.ToString());
                                String formatted_baptism_date = String.Format("{0:MMMM d, yyyy}", baptism_date).ToUpper();
                                if (formatted_baptism_date != "January 1, 1753")
                                {
                                    pdfFormFields.SetField("Date immersed", formatted_baptism_date);
                                }
                            }

                            pdfFormFields.SetField("Check Box1", row.Cells["gender"].Value.ToString().Trim() == "Male" ? "Yes" : "0");
                            pdfFormFields.SetField("Check Box2", row.Cells["gender"].Value.ToString().Trim() == "Female" ? "Yes" : "0");
                            pdfFormFields.SetField("Check Box3", row.Cells["hope"].Value.ToString().Trim() == "Other sheep" ? "Yes" : "0");
                            pdfFormFields.SetField("Check Box4", row.Cells["hope"].Value.ToString().Trim() == "Anointed" ? "Yes" : "0");
                            pdfFormFields.SetField("Check Box5", row.Cells["privilege"].Value.ToString().Trim() == "Elder" ? "Yes" : "0");
                            pdfFormFields.SetField("Check Box6", row.Cells["privilege"].Value.ToString().Trim() == "Ministerial Servant" ? "Yes" : "0");
                            pdfFormFields.SetField("Check Box7", row.Cells["hour_type"].Value.ToString().Trim() == "Regular Pioneer" ? "Yes" : "0");
                            int selected_year = Convert.ToInt32(service_yearComboBox.Text);
                            this.publishers.publisher_field_service_report_viewBindingSource.Filter = "publisher_id = " + row.Cells[0].Value + @" AND [report_date] >= '" + (selected_year - 1).ToString() + "-09-30' AND [report_date] <= '" + selected_year + "-08-31'";
                            int total_p = 0;
                            int total_v = 0;
                            double total_h = 0;
                            int total_r = 0;
                            int total_b = 0;

                            int count_p = 0;
                            int count_v = 0;
                            int count_h = 0;
                            int count_r = 0;
                            int count_b = 0;

                            foreach (DataGridViewRow row2 in this.publishers.publisher_field_service_report_viewDataGridView.Rows)
                            {
                                if (row2.Cells[0].Value != null)
                                {
                                    DateTime datevalue = (Convert.ToDateTime(row2.Cells["_report_date"].Value.ToString()));
                                    int mnt = datevalue.Month;
                                    int sub = mnt > 8 ? (mnt - 8) : (mnt + 4);
                                    String monthString = getMonthString(mnt);

                                    if (row2.Cells["_placements"].Value == DBNull.Value)
                                    {
                                        pdfFormFields.SetField("1-Place_" + sub, "");
                                    }
                                    else
                                    {
                                        pdfFormFields.SetField("1-Place_" + sub, row2.Cells["_placements"].Value.ToString());
                                        total_p += Convert.ToInt32(row2.Cells["_placements"].Value);
                                        count_p++;
                                    }
                                    if (row2.Cells["_videos"].Value == DBNull.Value)
                                    {
                                        pdfFormFields.SetField("1-Video_" + sub, "");
                                    }
                                    else
                                    {
                                        pdfFormFields.SetField("1-Video_" + sub, row2.Cells["_videos"].Value.ToString());
                                        total_v += Convert.ToInt32(row2.Cells["_videos"].Value);
                                        count_v++;
                                    }
                                    if (row2.Cells["_hours"].Value == DBNull.Value)
                                    {
                                        pdfFormFields.SetField("1-Hours_" + sub, "");
                                    }
                                    else
                                    {
                                        pdfFormFields.SetField("1-Hours_" + sub, row2.Cells["_hours"].Value.ToString());
                                        total_h += Convert.ToDouble(row2.Cells["_hours"].Value);
                                        count_h++;
                                    }
                                    if (row2.Cells["_return_visits"].Value == DBNull.Value)
                                    {
                                        pdfFormFields.SetField("1-RV_" + sub, "");
                                    }
                                    else
                                    {
                                        pdfFormFields.SetField("1-RV_" + sub, row2.Cells["_return_visits"].Value.ToString());
                                        total_r += Convert.ToInt32(row2.Cells["_return_visits"].Value);
                                        count_r++;
                                    }
                                    if (row2.Cells["_bible_studies"].Value == DBNull.Value)
                                    {
                                        pdfFormFields.SetField("1-Studies_" + sub, "");
                                    }
                                    else
                                    {
                                        pdfFormFields.SetField("1-Studies_" + sub, row2.Cells["_bible_studies"].Value.ToString());
                                        total_b += Convert.ToInt32(row2.Cells["_bible_studies"].Value);
                                        count_b++;
                                    }
                                    if (row2.Cells["_remarks"].Value == DBNull.Value)
                                    {
                                        pdfFormFields.SetField("Remarks" + monthString, "");
                                    }
                                    else
                                    {
                                        pdfFormFields.SetField("Remarks" + monthString, row2.Cells["_remarks"].Value.ToString());
                                    }
                                }
                            }
                            if (total_h > 0.0)
                            {
                                pdfFormFields.SetField("1-Place_Total", total_p.ToString());
                                pdfFormFields.SetField("1-Video_Total", total_v.ToString());
                                pdfFormFields.SetField("1-Hours_Total", total_h.ToString("0.##"));
                                pdfFormFields.SetField("1-RV_Total", total_r.ToString());
                                pdfFormFields.SetField("1-Studies_Total", total_b.ToString());

                                pdfFormFields.SetField("1-Place_Average", ((double)total_p / (double)count_p).ToString("0.##"));
                                pdfFormFields.SetField("1-Video_Average", ((double)total_v / (double)count_v).ToString("0.##"));
                                pdfFormFields.SetField("1-Hours_Average", ((double)total_h / (double)count_h).ToString("0.##"));
                                pdfFormFields.SetField("1-RV_Average", ((double)total_r / (double)count_r).ToString("0.##"));
                                pdfFormFields.SetField("1-Studies_Average", ((double)total_b / (double)count_r).ToString("0.##"));
                            }
                            pdfFormFields.SetField("Service Year", selected_year.ToString());



                            this.publishers.publisher_field_service_report_viewBindingSource.Filter = "publisher_id = " + row.Cells[0].Value + @" AND [report_date] >= '" + selected_year.ToString() + "-09-30' AND [report_date] <= '" + (selected_year + 1) + "-08-31'";
                            int total_p_2 = 0;
                            int total_v_2 = 0;
                            double total_h_2 = 0;
                            int total_r_2 = 0;
                            int total_b_2 = 0;

                            int count_p_2 = 0;
                            int count_v_2 = 0;
                            int count_h_2 = 0;
                            int count_r_2 = 0;
                            int count_b_2 = 0;

                            foreach (DataGridViewRow row2 in this.publishers.publisher_field_service_report_viewDataGridView.Rows)
                            {
                                if (row2.Cells[0].Value != null)
                                {
                                    DateTime datevalue = (Convert.ToDateTime(row2.Cells["_report_date"].Value.ToString()));
                                    int mnt = datevalue.Month;
                                    int sub = mnt > 8 ? (mnt - 8) : (mnt + 4);
                                    String monthString = getMonthString(mnt);

                                    if (row2.Cells["_placements"].Value == DBNull.Value)
                                    {
                                        pdfFormFields.SetField("2-Place_" + sub, "");
                                    }
                                    else
                                    {
                                        pdfFormFields.SetField("2-Place_" + sub, row2.Cells["_placements"].Value.ToString());
                                        total_p_2 += Convert.ToInt32(row2.Cells["_placements"].Value);
                                        count_p_2++;
                                    }
                                    if (row2.Cells["_videos"].Value == DBNull.Value)
                                    {
                                        pdfFormFields.SetField("2-Video_" + sub, "");
                                    }
                                    else
                                    {
                                        pdfFormFields.SetField("2-Video_" + sub, row2.Cells["_videos"].Value.ToString());
                                        total_v_2 += Convert.ToInt32(row2.Cells["_videos"].Value);
                                        count_v_2++;
                                    }
                                    if (row2.Cells["_hours"].Value == DBNull.Value)
                                    {
                                        pdfFormFields.SetField("2-Hours_" + sub, "");
                                    }
                                    else
                                    {
                                        pdfFormFields.SetField("2-Hours_" + sub, row2.Cells["_hours"].Value.ToString());
                                        total_h_2 += Convert.ToDouble(row2.Cells["_hours"].Value);
                                        count_h_2++;
                                    }
                                    if (row2.Cells["_return_visits"].Value == DBNull.Value)
                                    {
                                        pdfFormFields.SetField("2-RV_" + sub, "");
                                    }
                                    else
                                    {
                                        pdfFormFields.SetField("2-RV_" + sub, row2.Cells["_return_visits"].Value.ToString());
                                        total_r_2 += Convert.ToInt32(row2.Cells["_return_visits"].Value);
                                        count_r_2++;
                                    }
                                    if (row2.Cells["_bible_studies"].Value == DBNull.Value)
                                    {
                                        pdfFormFields.SetField("2-Studies_" + sub, "");
                                    }
                                    else
                                    {
                                        pdfFormFields.SetField("2-Studies_" + sub, row2.Cells["_bible_studies"].Value.ToString());
                                        total_b_2 += Convert.ToInt32(row2.Cells["_bible_studies"].Value);
                                        count_b_2++;
                                    }
                                    if (row2.Cells["_remarks"].Value == DBNull.Value)
                                    {
                                        pdfFormFields.SetField("Remarks" + monthString + "_2", "");
                                    }
                                    else
                                    {
                                        pdfFormFields.SetField("Remarks" + monthString + "_2", row2.Cells["_remarks"].Value.ToString());
                                    }

                                }
                            }
                            if (total_h_2 > 0.0)
                            {
                                pdfFormFields.SetField("2-Place_Total", total_p_2.ToString());
                                pdfFormFields.SetField("2-Video_Total", total_v_2.ToString());
                                pdfFormFields.SetField("2-Hours_Total", total_h_2.ToString("0.##"));
                                pdfFormFields.SetField("2-RV_Total", total_r_2.ToString());
                                pdfFormFields.SetField("2-Studies_Total", total_b_2.ToString());

                                pdfFormFields.SetField("2-Place_Average", ((double)total_p_2 / (double)count_p_2).ToString("0.##"));
                                pdfFormFields.SetField("2-Video_Average", ((double)total_v_2 / (double)count_v_2).ToString("0.##"));
                                pdfFormFields.SetField("2-Hours_Average", ((double)total_h_2 / (double)count_h_2).ToString("0.##"));
                                pdfFormFields.SetField("2-RV_Average", ((double)total_r_2 / (double)count_r_2).ToString("0.##"));
                                pdfFormFields.SetField("2-Studies_Average", ((double)total_b_2 / (double)count_r_2).ToString("0.##"));
                            }
                            pdfFormFields.SetField("Service Year_2", (selected_year + 1).ToString());

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
            Singleton.publisherCard = null;
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
                    var arr = new[] { "Regular Pioneer", "Auxiliary Pioneer", "Publisher" };

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
                        this.publishers.publisher_field_service_report_viewBindingSource.Filter = @"[hour_type] LIKE '%" + str + "%'" + " AND [report_date] >= '" + (selected_year_summary - 1).ToString() + "-09-30' AND [report_date] <= '" + selected_year_summary + "-08-31'" + " AND [hours] > 0"; 

                        foreach (DataGridViewRow row2 in this.publishers.publisher_field_service_report_viewDataGridView.Rows)
                        {
                            if (row2.Cells[0].Value != null)
                            {
                                DateTime datevalue = (Convert.ToDateTime(row2.Cells["_report_date"].Value.ToString()));
                                int mnt = datevalue.Month;
                                int sub = mnt > 8 ? (mnt - 8) : (mnt + 4);
                                String monthString = getMonthString(mnt);


                                if (row2 != null && row2.Cells[0].Value != null && Convert.ToBoolean(row2.Cells["_active"].Value) == false)
                                {
                                    if (pdfFormFields.GetField("1-Place_" + sub) == null || pdfFormFields.GetField("1-Place_" + sub) == "")
                                    {
                                        pdfFormFields.SetField("1-Place_" + sub, "0");
                                    }
                                    pdfFormFields.SetField("1-Place_" + sub, (Convert.ToInt32(pdfFormFields.GetField("1-Place_" + sub)) + Convert.ToInt32(row2.Cells["_placements"].Value.ToString())).ToString());
                                }
                                if (row2.Cells["_videos"].Value != DBNull.Value)
                                {
                                    if (pdfFormFields.GetField("1-Video_" + sub) == null || pdfFormFields.GetField("1-Video_" + sub) == "")
                                    {
                                        pdfFormFields.SetField("1-Video_" + sub, "0");
                                    }
                                    pdfFormFields.SetField("1-Video_" + sub, (Convert.ToInt32(pdfFormFields.GetField("1-Video_" + sub)) + Convert.ToInt32(row2.Cells["_videos"].Value.ToString())).ToString());
                                }
                                if (row2.Cells["_hours"].Value != DBNull.Value)
                                {
                                    if (pdfFormFields.GetField("1-Hours_" + sub) == null || pdfFormFields.GetField("1-Hours_" + sub) == "")
                                    {
                                        pdfFormFields.SetField("1-Hours_" + sub, "0.00");
                                    }

                                    
                                    pdfFormFields.SetField("1-Hours_" + sub, (Convert.ToDouble(pdfFormFields.GetField("1-Hours_" + sub)) + Convert.ToDouble(row2.Cells["_hours"].Value.ToString())).ToString());
                                }
                                if (row2.Cells["_return_visits"].Value != DBNull.Value)
                                {
                                    if (pdfFormFields.GetField("1-RV_" + sub) == null || pdfFormFields.GetField("1-RV_" + sub) == "")
                                    {
                                        pdfFormFields.SetField("1-RV_" + sub, "0");
                                    }
                                    pdfFormFields.SetField("1-RV_" + sub, (Convert.ToInt32(pdfFormFields.GetField("1-RV_" + sub)) + Convert.ToInt32(row2.Cells["_return_visits"].Value.ToString())).ToString());
                                }
                                if (row2.Cells["_bible_studies"].Value != DBNull.Value)
                                {
                                    if (pdfFormFields.GetField("1-Studies_" + sub) == null || pdfFormFields.GetField("1-Studies_" + sub) == "")
                                    {
                                        pdfFormFields.SetField("1-Studies_" + sub, "0");
                                    }
                                    pdfFormFields.SetField("1-Studies_" + sub, (Convert.ToInt32(pdfFormFields.GetField("1-Studies_" + sub)) + Convert.ToInt32(row2.Cells["_bible_studies"].Value.ToString())).ToString());
                                }

                                if (pdfFormFields.GetField("Remarks" + monthString) == null || pdfFormFields.GetField("Remarks" + monthString) == "")
                                {
                                    pdfFormFields.SetField("Remarks" + monthString, "0");
                                }
                                pdfFormFields.SetField("Remarks" + monthString, (Convert.ToInt32(pdfFormFields.GetField("Remarks" + monthString)) + 1).ToString());

                            }
                        }

                        this.publishers.publisher_field_service_report_viewBindingSource.Filter = @"[hour_type] LIKE '%" + str + "%'" + " AND [report_date] >= '" + (selected_year_summary).ToString() + "-09-30' AND [report_date] <= '" + (selected_year_summary + 1).ToString() + "-08-31'" + " AND [hours] > 0";

                        foreach (DataGridViewRow row2 in this.publishers.publisher_field_service_report_viewDataGridView.Rows)
                        {
                            if (row2 != null && row2.Cells[0].Value != null && Convert.ToBoolean(row2.Cells["_active"].Value) == false)
                            {
                                DateTime datevalue = (Convert.ToDateTime(row2.Cells["_report_date"].Value.ToString()));
                                int mnt = datevalue.Month;
                                int sub = mnt > 8 ? (mnt - 8) : (mnt + 4);
                                String monthString = getMonthString(mnt);

                                if (row2.Cells["_placements"].Value != DBNull.Value)
                                {
                                    if (pdfFormFields.GetField("2-Place_" + sub) == null || pdfFormFields.GetField("2-Place_" + sub) == "")
                                    {
                                        pdfFormFields.SetField("2-Place_" + sub, "0");
                                    }
                                    pdfFormFields.SetField("2-Place_" + sub, (Convert.ToInt32(pdfFormFields.GetField("2-Place_" + sub)) + Convert.ToInt32(row2.Cells["_placements"].Value.ToString())).ToString());
                                }
                                if (row2.Cells["_videos"].Value != DBNull.Value)
                                {
                                    if (pdfFormFields.GetField("2-Video_" + sub) == null || pdfFormFields.GetField("2-Video_" + sub) == "")
                                    {
                                        pdfFormFields.SetField("2-Video_" + sub, "0");
                                    }
                                    pdfFormFields.SetField("2-Video_" + sub, (Convert.ToInt32(pdfFormFields.GetField("2-Video_" + sub)) + Convert.ToInt32(row2.Cells["_videos"].Value.ToString())).ToString());
                                }
                                if (row2.Cells["_hours"].Value != DBNull.Value)
                                {
                                    if (pdfFormFields.GetField("2-Hours_" + sub) == null || pdfFormFields.GetField("2-Hours_" + sub) == "")
                                    {
                                        pdfFormFields.SetField("2-Hours_" + sub, "0.00");
                                    }

                                    
                                    pdfFormFields.SetField("2-Hours_" + sub, (Convert.ToDouble(pdfFormFields.GetField("2-Hours_" + sub)) + Convert.ToDouble(row2.Cells["_hours"].Value.ToString())).ToString());
                                }
                                if (row2.Cells["_return_visits"].Value != DBNull.Value)
                                {
                                    if (pdfFormFields.GetField("2-RV_" + sub) == null || pdfFormFields.GetField("2-RV_" + sub) == "")
                                    {
                                        pdfFormFields.SetField("2-RV_" + sub, "0");
                                    }
                                    pdfFormFields.SetField("2-RV_" + sub, (Convert.ToInt32(pdfFormFields.GetField("2-RV_" + sub)) + Convert.ToInt32(row2.Cells["_return_visits"].Value.ToString())).ToString());
                                }
                                if (row2.Cells["_bible_studies"].Value != DBNull.Value)
                                {
                                    if (pdfFormFields.GetField("2-Studies_" + sub) == null || pdfFormFields.GetField("2-Studies_" + sub) == "")
                                    {
                                        pdfFormFields.SetField("2-Studies_" + sub, "0");
                                    }
                                    pdfFormFields.SetField("2-Studies_" + sub, (Convert.ToInt32(pdfFormFields.GetField("2-Studies_" + sub)) + Convert.ToInt32(row2.Cells["_bible_studies"].Value.ToString())).ToString());
                                }

                                if (pdfFormFields.GetField("Remarks" + monthString + "_2") == null || pdfFormFields.GetField("Remarks" + monthString + "_2") == "")
                                {
                                    pdfFormFields.SetField("Remarks" + monthString + "_2", "0");
                                }
                                pdfFormFields.SetField("Remarks" + monthString + "_2", (Convert.ToInt32(pdfFormFields.GetField("Remarks" + monthString + "_2")) + 1).ToString());

                            }
                        }
                       
                        pdfFormFields.SetField("Service Year", (selected_year_summary).ToString());
                        pdfFormFields.SetField("Service Year_2", (selected_year_summary + 1).ToString());

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
