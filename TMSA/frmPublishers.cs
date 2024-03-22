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

namespace TMSA
{
    public partial class frmPublishers : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        string sqlstr;

        bool isDirty = false;
        bool rowsDeleted = false;
        bool bindingNavigator_ItemClicked = false;
        public frmPublishers()
        {
            InitializeComponent();
            this.bindingNavigatorPositionItem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(CheckEnterKeyPress);

            tbDobMask.BackColor = Color.White;
            tbDobMask.ForeColor = Color.White;
            tbDobMask.ReadOnly = true;

            tbBaptismDateMask.BackColor = Color.White;
            tbBaptismDateMask.ForeColor = Color.White;
            tbBaptismDateMask.ReadOnly = true;
        }

        public SlightlyMoreSophisticatedDirtyTracker _dirtyTracker;
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                this.tMSADataSet.EnforceConstraints = false;
                this.publisherTableAdapter.Fill(this.tMSADataSet.publisher);
                this.publisher_field_service_report_viewTableAdapter.Fill(this.tMSADataSet.publisher_field_service_report_view);

            }
            catch (Exception ex)
            {
                this.Close();
                ex.sqlexception();
            }

            _dirtyTracker = new SlightlyMoreSophisticatedDirtyTracker(this);
            _dirtyTracker.MarkAsClean();

            if (publisherDataGridView.Rows.Count < 1)
            {
                tbDobMask.Visible = true;
                tbBaptismDateMask.Visible = true;
            }
        }


        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                this.openFileDialog1.Title = "Select Image";
                openFileDialog1.Filter = "All Files|*.*|Bitamps|*.bmp|GIFs|*.gif|JPEGs|*.jpg";
                openFileDialog1.FilterIndex = 1;
                openFileDialog1.FileName = "";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    picturePictureBox.Image = Image.FromFile(openFileDialog1.FileName);
                    picturePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    picturePictureBox.BorderStyle = BorderStyle.FixedSingle;
                }
            }
            catch (Exception ex)
            {
                ex.sqlexception();
            }
        }

        private void btnRemoveImage_Click(object sender, EventArgs e)
        {
            picturePictureBox.Image = null;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            cmbHope.SelectedIndex = 0;
            cmbGender.SelectedIndex = 0;
            cmbPubliserType.SelectedIndex = 0;
            cmbHourType.SelectedIndex = 0;
            cmbPrivilege.SelectedIndex = 0;
            cmbGroup.SelectedIndex = 0;
            try
            {
                string searchstring = txtSearch.Text;
                publisherBindingSource.Filter = "last_name LIKE '%" + searchstring + "%' OR other_names LIKE '%" + searchstring + "%'";
            }
            catch (Exception ex)
            {
                ex.sqlexception();
            }
        }

        private void publisherBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            SaveDocument();
        }

        public bool SaveDocument()
        {
            try
            {
                this.Validate();
                this.publisherBindingSource.EndEdit();
                this.publisherTableAdapter.Update(this.tMSADataSet);
                _dirtyTracker.MarkAsClean();
                rowsDeleted = false;
                return true;
            }
            catch (Exception ex)
            {
                ex.sqlexception();
                return false;
            }
        }

        private void publisherDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (publisherDataGridView.CurrentRow == null)
            {
                return;
            }

            if (publisherDataGridView.CurrentRow.Cells["dob"].Value == DBNull.Value)
            {
                tbDobMask.Visible = true;
            }
            else
            {
                tbDobMask.Visible = false;
            }


            if (publisherDataGridView.CurrentRow.Cells["baptisam_date"].Value == DBNull.Value)
            {
                tbBaptismDateMask.Visible = true;
            }
            else
            {
                tbBaptismDateMask.Visible = false;
            }


            List<String> genders = new List<string>();
            genders.Add("Male");
            genders.Add("Female");

            List<String> publisher_types = new List<string>();
            publisher_types.Add("Unbaptized Publisher");
            publisher_types.Add("Baptized Publisher");

            List<String> hour_types = new List<string>();
            hour_types.Add("Field Missionary");
            hour_types.Add("Special Pioneer");
            hour_types.Add("Regular Pioneer");
            hour_types.Add("Auxiliary Pioneer");
            hour_types.Add("Publisher");

            List<String> privileges = new List<string>();
            privileges.Add("n/a");
            privileges.Add("Non");
            privileges.Add("Elder");
            privileges.Add("Ministerial Servant");


            List<String> groups = new List<string>();
            groups.Add("Group 1");
            groups.Add("Group 2");
            groups.Add("Group 3");
            groups.Add("Group 4");
            groups.Add("Group 5");
            groups.Add("Group 6");
            groups.Add("Group 7");
            groups.Add("Group 8");
            groups.Add("Group 9");
            groups.Add("Group 10");

            List<String> hopes = new List<string>();
            hopes.Add("Anointed");
            hopes.Add("Other sheep");

            genderComboBox.SelectedIndex = genders.IndexOf(publisherDataGridView.CurrentRow.Cells["gender"].Value.ToString().Trim());
            publisher_typeComboBox.SelectedIndex = publisher_types.IndexOf(publisherDataGridView.CurrentRow.Cells["publisher_type"].Value.ToString().Trim());
            hour_typeComboBox.SelectedIndex = hour_types.IndexOf(publisherDataGridView.CurrentRow.Cells["hour_type"].Value.ToString().Trim());
            privilegeComboBox.SelectedIndex = privileges.IndexOf(publisherDataGridView.CurrentRow.Cells["privilege"].Value.ToString().Trim());
            groupComboBox.SelectedIndex = groups.IndexOf(publisherDataGridView.CurrentRow.Cells["group"].Value.ToString().Trim());
            hopeComboBox.SelectedIndex = hopes.IndexOf(publisherDataGridView.CurrentRow.Cells["hope"].Value.ToString().Trim());

            if (_dirtyTracker != null)
            {
                if (!isDirty)
                {
                    _dirtyTracker.MarkAsClean();
                }
            }
        }

        private void last_nameTextBox_Click(object sender, EventArgs e)
        {
            last_nameTextBox.Text = last_nameTextBox.Text.Trim();
        }

        private void other_namesTextBox_Click(object sender, EventArgs e)
        {
            other_namesTextBox.Text = other_namesTextBox.Text.Trim();
        }

        private void contactTextBox_Click(object sender, EventArgs e)
        {
            contactTextBox.Text = contactTextBox.Text.Trim();
        }

        private void addressTextBox_Click(object sender, EventArgs e)
        {
            addressTextBox.Text = addressTextBox.Text.Trim();
        }

        private void groupComboBox_Click(object sender, EventArgs e)
        {
            groupComboBox.Text = groupComboBox.Text.Trim();
        }

        private void btnDob_Click(object sender, EventArgs e)
        {
            publisherDataGridView.CurrentRow.Cells["dob"].Value = DBNull.Value;
            tbDobMask.Visible = true;
        }

        private void btnBaptismDate_Click(object sender, EventArgs e)
        {
            publisherDataGridView.CurrentRow.Cells["baptisam_date"].Value = DBNull.Value;
            tbBaptismDateMask.Visible = true;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Singleton.publishers = null;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            bindingNavigator_ItemClicked = false;
            tbDobMask.Visible = true;
            tbBaptismDateMask.Visible = true;
            publisherDataGridView.CurrentRow.Cells["dob"].Value = DBNull.Value;
            publisherDataGridView.CurrentRow.Cells["baptisam_date"].Value = DBNull.Value;
            activeCheckBox.Checked = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (publisherDataGridView.RowCount < 1)
            {
                if (isDirty)
                {
                    savePropt(e);
                }
            }
            else if (rowsDeleted || (_dirtyTracker != null && _dirtyTracker.IsDirty))
            {
                savePropt(e);
            }
        }

        public bool saved()
        {
            bool all_saved = true;
            if (publisherDataGridView.RowCount < 1)
            {
                if (isDirty)
                {
                    all_saved = false;
                }
            }
            else if (rowsDeleted || (_dirtyTracker != null && _dirtyTracker.IsDirty))
            {
                all_saved = false;
            }
            return all_saved;
        }

        private void savePropt(FormClosingEventArgs e)
        {
            frmMessageBoxForm messageBox = new frmMessageBoxForm("Save changes before closing?");
            messageBox.yes = true;
            messageBox.no = true;
            messageBox.cancel = true;
            messageBox.ok = false;
            DialogResult result = messageBox.ShowDialog();

            switch (result)
            {
                case DialogResult.Yes:
                    Cursor.Current = Cursors.WaitCursor;
                    if (!SaveDocument())
                    {
                        e.Cancel = true;
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

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (_dirtyTracker != null)
            {
                isDirty = _dirtyTracker.IsDirty ? true : false;
            }

            txtSearch.Text = "";
            try
            {
                string filter = "";

                if (!string.IsNullOrEmpty(cmbGender.Text))
                {
                    filter += "gender = '" + cmbGender.Text + "' ";
                }
                if (!string.IsNullOrEmpty(cmbHope.Text))
                {
                    if (filter.Length > 0) filter += "AND ";
                    filter += "hope = '" + cmbHope.Text + "' ";
                }
                if (!string.IsNullOrEmpty(cmbPrivilege.Text))
                {
                    if (filter.Length > 0) filter += "AND ";
                    filter += "privilege = '" + cmbPrivilege.Text + "' ";
                }
                if (!string.IsNullOrEmpty(cmbPubliserType.Text))
                {
                    if (filter.Length > 0) filter += "AND ";
                    filter += "publisher_type = '" + cmbPubliserType.Text + "' ";
                }
                if (!string.IsNullOrEmpty(cmbHourType.Text))
                {
                    if (filter.Length > 0) filter += "AND ";
                    filter += "hour_type = '" + cmbHourType.Text + "' ";
                }
                if (!string.IsNullOrEmpty(cmbGroup.Text))
                {
                    if (filter.Length > 0) filter += "AND ";
                    filter += "group = '" + cmbGroup.Text + "' ";
                }
                publisherBindingSource.Filter = filter;

            }
            catch (Exception ex)
            {
                ex.sqlexception();
            }
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            if (_dirtyTracker != null)
            {
                isDirty = _dirtyTracker.IsDirty ? true : false;
            }

            publisherBindingSource.Filter = "";
            txtSearch.Clear();

            cmbHope.SelectedIndex = 0;
            cmbGender.SelectedIndex = 0;
            cmbPubliserType.SelectedIndex = 0;
            cmbHourType.SelectedIndex = 0;
            cmbPrivilege.SelectedIndex = 0;
            cmbGroup.SelectedIndex = 0;
        }

        private void txtSearch_DoubleClick(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            txtSearch.Focus();
        }

        private void bindingNavigatorDeleteItem_EnabledChanged(object sender, EventArgs e)
        {
            if (publisherDataGridView.CurrentRow == null)
            {
                return;
            }
            if (bindingNavigatorDeleteItem.Enabled == false)
            {
                tbDobMask.Visible = true;

                tbBaptismDateMask.Visible = true;
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            frmMessageBoxForm messageBox;
            if (publisherDataGridView.SelectedRows.Count == 0)
            {
                messageBox = new frmMessageBoxForm("No rows selected");
                messageBox.ShowDialog();
                return;
            }
            else if (publisherDataGridView.SelectedRows.Count == 1)
            {
                messageBox = new frmMessageBoxForm("Delete selected row?");
            }
            else
            {
                messageBox = new frmMessageBoxForm("Delete selected rows?");
            }

            messageBox.yes = true;
            messageBox.no = true;
            messageBox.cancel = true;
            messageBox.ok = false;
            DialogResult result = messageBox.ShowDialog();

            switch (result)
            {
                case DialogResult.Yes:
                    foreach (DataGridViewRow row in publisherDataGridView.SelectedRows)
                    {
                        rowsDeleted = true;
                        bindingNavigator_ItemClicked = false;
                        publisherDataGridView.Rows.RemoveAt(row.Index);

                    }
                    break;

                case DialogResult.No:
                    break;

                case DialogResult.Cancel:
                    break;
            }
        }


        string oldValue = "";
        private void CheckEnterKeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return && bindingNavigatorPositionItem.Text != oldValue)
            {
                oldValue = bindingNavigatorPositionItem.Text;
                if (_dirtyTracker != null)
                {
                    bindingNavigator_ItemClicked = true;
                    isDirty = _dirtyTracker.IsDirty ? true : false;
                }
            }
        }

        private void bindingNavigatorPositionItem_Click(object sender, EventArgs e)
        {
            bindingNavigator_ItemClicked = false;
        }

        private void publisherDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (bindingNavigator_ItemClicked || publisherDataGridView.CurrentRow == null)
            {
                bindingNavigator_ItemClicked = false;
                return;
            }

            if (_dirtyTracker != null)
            {
                isDirty = _dirtyTracker.IsDirty ? true : false;
            }
        }

        private void publisherBindingNavigator_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (_dirtyTracker != null)
            {
                bindingNavigator_ItemClicked = true;
                isDirty = _dirtyTracker.IsDirty ? true : false;
            }
        }

        private void bindingNavigatorCountItem_Click(object sender, EventArgs e)
        {
            bindingNavigator_ItemClicked = false;
        }

        private void bindingNavigatorSeparator_Click(object sender, EventArgs e)
        {
            bindingNavigator_ItemClicked = false;
        }

        private void bindingNavigatorSeparator1_Click(object sender, EventArgs e)
        {
            bindingNavigator_ItemClicked = false;
        }

        private void bindingNavigatorSeparator2_Click(object sender, EventArgs e)
        {
            bindingNavigator_ItemClicked = false;
        }

        private void txtSearch_MouseEnter(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSearch.Text))
            {
                toolTip1.SetToolTip(txtSearch, "Double-click to clear text.");
            }
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (_dirtyTracker != null)
            {
                isDirty = _dirtyTracker.IsDirty ? true : false;
            }
        }

        private void dobDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (publisherDataGridView.CurrentRow == null)
            {
                return;
            }
            tbDobMask.Visible = false;
        }

        private void baptisam_dateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (publisherDataGridView.CurrentRow == null)
            {
                return;
            }
            tbBaptismDateMask.Visible = false;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            bindingNavigator_ItemClicked = false;
            frmMessageBoxForm messageBox = new frmMessageBoxForm("Delete all field service records for " + other_namesTextBox.Text.Trim() + " " + last_nameTextBox.Text.Trim() + " ?");
            messageBox.yes = true;
            messageBox.no = true;
            messageBox.ok = false;
            DialogResult result = messageBox.ShowDialog();
            if (result == DialogResult.Yes)
            {
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    con = new SqlConnection(Properties.Settings.Default.TMSAConnectionString);
                    con.Open();
                    sqlstr = "DELETE FROM publisher_field_service_report WHERE publisher_id = " + publisherDataGridView.CurrentRow.Cells["publisher_id"].Value.ToString();
                    cmd = new SqlCommand(sqlstr, con);
                    dr = cmd.ExecuteReader();
                    //this.getPublisherCounselPointsTableAdapter.Fill(this.tMSADataSet.GetPublisherCounselPoints, publisherId);

                }
                catch (Exception ex)
                {
                    ex.sqlexception();
                }
                finally
                {
                    con.Close();
                }
            }
            else
            {
                return;
            }
        }

        private void tsDeleteAssignments_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Singleton.ShowPublisherCard(this);


            frmPublisherCard publisherCard = new frmPublisherCard(this);
            publisherCard.ShowDialog();
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

        private void publisher_field_service_report_viewDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void tsPublisherCards_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Singleton.ShowPublisherCard(this);
        }

        private void tsDeleteAssignments_Click_1(object sender, EventArgs e)
        {
            bindingNavigator_ItemClicked = false;
            frmMessageBoxForm messageBox = new frmMessageBoxForm("Delete all field service records for " + other_namesTextBox.Text.Trim() + " " + last_nameTextBox.Text.Trim() + " ?");
            messageBox.yes = true;
            messageBox.no = true;
            messageBox.ok = false;
            DialogResult result = messageBox.ShowDialog();
            if (result == DialogResult.Yes)
            {
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    con = new SqlConnection(Properties.Settings.Default.TMSAConnectionString);
                    con.Open();
                    sqlstr = "DELETE FROM publisher_field_service_report WHERE publisher_id = " + publisherDataGridView.CurrentRow.Cells["publisher_id"].Value.ToString();
                    cmd = new SqlCommand(sqlstr, con);
                    dr = cmd.ExecuteReader();
                    //this.getPublisherCounselPointsTableAdapter.Fill(this.tMSADataSet.GetPublisherCounselPoints, publisherId);

                }
                catch (Exception ex)
                {
                    ex.sqlexception();
                }
                finally
                {
                    con.Close();
                }
            }
            else
            {
                return;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            cmbHope.SelectedIndex = 0;
            cmbGender.SelectedIndex = 0;
            cmbPubliserType.SelectedIndex = 0;
            cmbHourType.SelectedIndex = 0;
            cmbPrivilege.SelectedIndex = 0;
            cmbGroup.SelectedIndex = 0;
            try
            {
                string searchstring = txtSearch.Text;
                publisherBindingSource.Filter = "last_name LIKE '%" + searchstring + "%' OR other_names LIKE '%" + searchstring + "%'";
            }
            catch (Exception ex)
            {
                ex.sqlexception();
            }
        }

        private void tbDobMask_Click(object sender, EventArgs e)
        {
            tbDobMask.Visible = false;
        }

        private void tbBaptismDateMask_Click(object sender, EventArgs e)
        {
            tbBaptismDateMask.Visible = false;
        }

        private void tsNewPublisherCards_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Singleton.ShowNewPublisherCard(this);
        }
    }
}
