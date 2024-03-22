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
using System.Data.OleDb;

namespace TMSA
{
    public partial class frmNewFSrecordsImport : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        string sqlstr;

        AutoCompleteStringCollection autoCompleteNameCollection;
        public frmNewFSrecordsImport()
        {
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
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    if (dataGridView1.RowCount > 0)
                    {
                        frmMessageBoxForm messageBox = new frmMessageBoxForm("Overwrite existing data ?");
                        messageBox.yes = false;
                        messageBox.no = false;
                        messageBox.cancel = true;
                        messageBox.btnCancel.Location = new Point(134, 150);
                        messageBox.ok = true;
                        DialogResult result = messageBox.ShowDialog();

                        switch (result)
                        {
                            case DialogResult.OK:
                                Cursor.Current = Cursors.WaitCursor;
                                dataGridView1.CancelEdit();
                                dataGridView1.Columns.Clear();
                                dataGridView1.DataSource = null;
                                importData(dlg.FileName);
                                break;

                            case DialogResult.Cancel:
                                // cancel the close
                                break;
                        }
                    }
                    else
                    {
                        importData(dlg.FileName);
                    }
                    
                }
            }
            catch (Exception ex)
            {
                this.Close();
                ex.sqlexception();
            }
        }

        private void importData(string fileName)
        {
            Cursor.Current = Cursors.WaitCursor;
            OleDbConnection myconnection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fileName + @"';Extended Properties='Excel 12.0;HDR=YES';");
            OleDbDataAdapter oda = new OleDbDataAdapter("Select * from [sheet1$]", myconnection);
            DataSet ds = new DataSet();
            oda.Fill(ds);

            // Convert the checkbox column values to 1 for checked and 0 for unchecked
            /*foreach (DataRow row in ds.Tables[0].Rows)
            {
                if (row["Shared in Ministry"] != DBNull.Value)
                {
                    row["Shared in Ministry"] = row["Shared in Ministry"].ToString() == "Yes" ? "1" : "0";
                }
            }*/

            dataGridView1.DataSource = ds.Tables[0];
            myconnection.Close();

            DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
            idColumn.Name = "publisher_id";
            idColumn.HeaderText = "PUBLISHER ID";
            idColumn.Visible = false;

            DataGridViewTextBoxColumn dateColumn = new DataGridViewTextBoxColumn();
            dateColumn.Name = "date";
            dateColumn.HeaderText = "DATE";
            dateColumn.Visible = false;

            DataGridViewTextBoxColumn monthColumn = new DataGridViewTextBoxColumn();
            monthColumn.Name = "report_date";
            monthColumn.HeaderText = "MONTH";
            monthColumn.Visible = false;

            DataGridViewComboBoxColumn hour_typeColumn = new DataGridViewComboBoxColumn();
            hour_typeColumn.Name = "hour_type";
            hour_typeColumn.HeaderText = "HOUR TYPE";

            List<String> hour_types = new List<string>();
            hour_types.Add("Field Missionary");
            hour_types.Add("Special Pioneer");
            hour_types.Add("Regular Pioneer");
            hour_types.Add("Auxiliary Pioneer");
            hour_types.Add("Publisher");

            hour_typeColumn.DataSource = hour_types;

            DataGridViewTextBoxColumn privilegeColumn = new DataGridViewTextBoxColumn();
            privilegeColumn.Name = "privilege";
            privilegeColumn.HeaderText = "PRIVILEGE";
            privilegeColumn.Visible = false;

            DataGridViewTextBoxColumn publisher_typeColumn = new DataGridViewTextBoxColumn();
            publisher_typeColumn.Name = "publisher_type";
            publisher_typeColumn.HeaderText = "PUBLISHER TYPE";
            publisher_typeColumn.Visible = false;

            DataGridViewTextBoxColumn groupColumn = new DataGridViewTextBoxColumn();
            groupColumn.Name = "group";
            groupColumn.HeaderText = "GROUP";
            groupColumn.Visible = false;

            dataGridView1.Columns.Insert(0, idColumn);

            dataGridView1.Columns.Insert(2, dateColumn);
            dataGridView1.Columns.Insert(3, monthColumn);
            dataGridView1.Columns.Insert(4, hour_typeColumn);
            dataGridView1.Columns.Insert(5, privilegeColumn);
            dataGridView1.Columns.Insert(6, publisher_typeColumn);
            dataGridView1.Columns.Insert(7, groupColumn);

            dataGridView1.Columns[1].Width = 169;

            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);

            autoFillFSrecords();

            btnSave.Enabled = true;
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

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex == 1)
            {
                TextBox nameAutoText = e.Control as TextBox;
                if (nameAutoText != null)
                {
                    nameAutoText.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    nameAutoText.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    populateNameSuggestions();
                    nameAutoText.AutoCompleteCustomSource = autoCompleteNameCollection;
                }
            }

        }

        private void populateNameSuggestions()
        {
            try
            {
                con = new SqlConnection(Properties.Settings.Default.TMSAConnectionString);
                con.Open();
                sqlstr = "Select other_names, last_name from [publisher]";
                cmd = new SqlCommand(sqlstr, con);
                dr = cmd.ExecuteReader();

                autoCompleteNameCollection = new AutoCompleteStringCollection();
                while (dr.Read())
                {
                    autoCompleteNameCollection.Add(dr["other_names"].ToString().Trim() + " " + dr["last_name"].ToString().Trim());
                }
            }
            catch (Exception ex)
            {
                ex.sqlexception();
            }
            finally
            {
                dr.Close();
                con.Close();
            }
        }

        private void frmFSrecordsImport_FormClosed(object sender, FormClosedEventArgs e)
        {
            Singleton.newFsrecordsimport = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            autoFillFSrecords();
        }        

        private IDictionary<string, string> getPublisherId(String name)
        {
            IDictionary<string, string> publisher = new Dictionary<string, string>();
            try
            {
                con = new SqlConnection(Properties.Settings.Default.TMSAConnectionString);
                con.Open();
                sqlstr = @"Select publisher_id, publisher_name, hour_type, privilege, publisher_type, [group] from [publisher_last_field_service_report_view] where publisher_name = '" + name + @"'";
                cmd = new SqlCommand(sqlstr, con);
                dr = cmd.ExecuteReader();
               
                while (dr.Read())
                {
                    publisher["publisher_id"] = dr["publisher_id"].ToString().Trim();
                    publisher["publisher_name"] = dr["publisher_name"].ToString().Trim();
                    publisher["hour_type"] = dr["hour_type"].ToString().Trim();
                    publisher["privilege"] = dr["privilege"].ToString().Trim();
                    publisher["publisher_type"] = dr["publisher_type"].ToString().Trim();
                    publisher["group"] = dr["group"].ToString().Trim();
                }
                return publisher;
            }
            catch (Exception ex)
            {
                ex.sqlexception();
                return publisher;
            }
            finally
            {
                if(dr != null)
                {
                    dr.Close();
                }
                if (con != null)
                {
                    con.Close();
                }
            }
        }

        private void frmFSrecordsImport_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            autoFillFSrecords();
            if (unvresolvedNamesExixt())
            {
                frmMessageBoxForm messageBox = new frmMessageBoxForm("Please resolve publisher names of red colored rows before saving.");
                messageBox.ShowDialog();
                return;
            }
            try
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (dataGridView1.Rows[i].Cells[0].Value.ToString() == null)
                    {
                        continue;
                    }
                    con = new SqlConnection(Properties.Settings.Default.TMSAConnectionString);
                    con.Open();
                    sqlstr = "Insert into publisher_field_service_report values (@publisher_id, @date, @report_date, @placements, @videos, @hours, @return_visits, @bible_studies, @remarks, @hour_type, @privilege, @publisher_type, @group, @shared_in_ministry)";

                    cmd = new SqlCommand(sqlstr, con);

                    cmd.Parameters.AddWithValue("@publisher_id", Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value.ToString()));
                    cmd.Parameters.AddWithValue("@date", DateTime.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString()));
                    cmd.Parameters.AddWithValue("@report_date", DateTime.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString()));
                    cmd.Parameters.AddWithValue("@placements", DBNull.Value);
                    cmd.Parameters.AddWithValue("@videos", DBNull.Value);
                    cmd.Parameters.AddWithValue("@return_visits", DBNull.Value);
                    if (dataGridView1.Rows[i].Cells[8].Value == DBNull.Value)
                    {
                        cmd.Parameters.AddWithValue("@shared_in_ministry", 0.00);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@shared_in_ministry", dataGridView1.Rows[i].Cells[8].Value.ToString() == "Yes" ? "1" : "0");
                    }
                    if (dataGridView1.Rows[i].Cells[9].Value == DBNull.Value)
                    {
                        cmd.Parameters.AddWithValue("@hours", 0.00);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@hours", Convert.ToDecimal(dataGridView1.Rows[i].Cells[9].Value.ToString()));
                    }
                    if (dataGridView1.Rows[i].Cells[10].Value == DBNull.Value)
                    {
                        cmd.Parameters.AddWithValue("@bible_studies", 0);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@bible_studies", Convert.ToInt32(dataGridView1.Rows[i].Cells[10].Value.ToString()));
                    }
                    if (dataGridView1.Rows[i].Cells[11].Value == DBNull.Value)
                    {
                        cmd.Parameters.AddWithValue("@remarks", "");
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@remarks", dataGridView1.Rows[i].Cells[11].Value.ToString());
                    }

                    if (dataGridView1.Rows[i].Cells[4].Value == DBNull.Value)
                    {
                        cmd.Parameters.AddWithValue("@hour_type", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@hour_type", dataGridView1.Rows[i].Cells[4].Value.ToString());
                    }
                    if (dataGridView1.Rows[i].Cells[5].Value == DBNull.Value)
                    {
                        cmd.Parameters.AddWithValue("@privilege", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@privilege", dataGridView1.Rows[i].Cells[5].Value.ToString());
                    }
                    if (dataGridView1.Rows[i].Cells[6].Value == DBNull.Value)
                    {
                        cmd.Parameters.AddWithValue("@publisher_type", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@publisher_type", dataGridView1.Rows[i].Cells[6].Value.ToString());
                    }
                    if (dataGridView1.Rows[i].Cells[7].Value == DBNull.Value)
                    {
                        cmd.Parameters.AddWithValue("@group", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@group", dataGridView1.Rows[i].Cells[7].Value.ToString());
                    }

                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                frmMessageBoxForm messageBox = new frmMessageBoxForm("Successfully saved!");
                messageBox.ShowDialog();
                dataGridView1.CancelEdit();
                dataGridView1.Columns.Clear();
                dataGridView1.DataSource = null;
                btnSave.Enabled = false;
            }
            catch (Exception ex)
            {
                ex.sqlexception();
            }
        }

        private bool unvresolvedNamesExixt()
        {

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.DefaultCellStyle.BackColor == Color.Red)
                {
                    return true;
                }
            }
            return false;
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void autoFillFSrecords()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value == null && row.Cells[1].Value != null)
                {
                    IDictionary<string, string> publisher = getPublisherId(row.Cells[1].Value.ToString().Trim().Replace("  ", " "));
                    if (!publisher.ContainsKey("publisher_id"))
                    {
                        row.DefaultCellStyle.BackColor = Color.Red;
                        continue;
                    }
                    row.DefaultCellStyle.BackColor = Color.White;
                    row.Cells[0].Value = publisher["publisher_id"];
                    row.Cells[1].Value = publisher["publisher_name"];
                    row.Cells[1].ReadOnly = true;
                    row.Cells[2].Value = reportMonthDateTimePicker.Value;
                    row.Cells[3].Value = reportMonthDateTimePicker.Value;
                    row.Cells[4].Value = publisher["hour_type"];
                    row.Cells[5].Value = publisher["privilege"];
                    row.Cells[6].Value = publisher["publisher_type"];
                    row.Cells[7].Value = publisher["group"];
                }
            }
        }

        private void frmFSrecordsImport_Load(object sender, EventArgs e)
        {
            
            reportMonthDateTimePicker.Value = (new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1)).AddDays(-1);
        }

        private void reportMonthDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            autoFillFSrecords();
        }
    }
}
