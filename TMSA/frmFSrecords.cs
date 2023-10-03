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

namespace TMSA
{
    public partial class frmFSrecords : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        string sqlstr;

        bool isDirty = false;
        bool rowsDeleted = false;
        bool bindingNavigator_ItemClicked = false;
        bool focus_set = false;
        public frmFSrecords(string id)
        {
            fsrecordrecordsid = id;
            InitializeComponent();

            this.bindingNavigatorPositionItem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(CheckEnterKeyPress);

            tbDateFilterMask.BackColor = Color.White;
            tbDateFilterMask.ForeColor = Color.White;
            tbDateFilterMask.ReadOnly = true;

            tbDateFilterMask.Visible = true;
        }

        public String fsrecordrecordsid
        {
            get;
            set;
        }

        public SlightlyMoreSophisticatedDirtyTracker _dirtyTracker;

        private void publisher_field_service_reportBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            SaveDocument();
        }

        public bool SaveDocument()
        {
            tbPublisherName.Focus();
            try
            {
                this.Validate();
                this.publisher_field_service_reportBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.tMSADataSet);
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

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                this.publisherTableAdapter.Fill(this.tMSADataSet.publisher);
                this.tMSADataSet.EnforceConstraints = false;
                this.publisher_field_service_reportTableAdapter.Fill(this.tMSADataSet.publisher_field_service_report);
                publisher_field_service_reportDataGridView.Sort(this.publisher_field_service_reportDataGridView.Columns[4], ListSortDirection.Ascending);

                if (fsrecordrecordsid != null)
                {
                    int index = publisher_field_service_reportBindingSource.Find("publisher_field_service_report_id", fsrecordrecordsid);

                    if (index >= 0)
                    {
                        publisher_field_service_reportBindingSource.Position = index;
                    }
                }
            }
            catch (Exception ex)
            {
                this.Close();
                ex.sqlexception();
            }

            loadDgv();

            _dirtyTracker = new SlightlyMoreSophisticatedDirtyTracker(this);
            _dirtyTracker.MarkAsClean();
        }

        private void loadDgv()
        {
            foreach (DataGridViewRow row in publisher_field_service_reportDataGridView.Rows)
            {
                row.Cells["publisher_name"].Value = row.Cells["publisher_other_names"].FormattedValue.ToString().Trim() + " " + row.Cells["publisher_last_name"].FormattedValue.ToString().Trim();
            }
            if (publisher_field_service_reportDataGridView.CurrentRow != null)
            {
                if (publisher_field_service_reportDataGridView.CurrentRow.Cells["publisher_name"].Value != null)
                {
                    tbPublisherName.Text = publisher_field_service_reportDataGridView.CurrentRow.Cells["publisher_name"].Value.ToString();
                }
                else
                {
                    tbPublisherName.Clear();
                }
            }
            if (_dirtyTracker != null)
            {
                if (!isDirty)
                {
                    _dirtyTracker.MarkAsClean();
                }
            }
        }

        public void onChoosePublisherCloseInit(String id)
        {
            publisher_field_service_reportDataGridView.CurrentRow.Cells["publisher_other_names"].Value = id;
            publisher_field_service_reportDataGridView.CurrentRow.Cells["publisher_last_name"].Value = id;
            String name = publisher_field_service_reportDataGridView.CurrentRow.Cells["publisher_other_names"].FormattedValue.ToString().Trim() + " " + publisher_field_service_reportDataGridView.CurrentRow.Cells["publisher_last_name"].FormattedValue.ToString().Trim();

            publisher_field_service_reportDataGridView.CurrentRow.Cells["publisher_name"].Value = name;
            tbPublisherName.Text = name;

            publisher_field_service_reportDataGridView.CurrentRow.Cells["group_actual"].Value = id;
            publisher_field_service_reportDataGridView.CurrentRow.Cells["hour_type_actual"].Value = id;
            publisher_field_service_reportDataGridView.CurrentRow.Cells["privilege_actual"].Value = id;
            publisher_field_service_reportDataGridView.CurrentRow.Cells["publisher_type_actual"].Value = id;

            publisher_field_service_reportDataGridView.CurrentRow.Cells["group"].Value = groupTextBox.Text = publisher_field_service_reportDataGridView.CurrentRow.Cells["group_actual"].FormattedValue.ToString().Trim();
            publisher_field_service_reportDataGridView.CurrentRow.Cells["hour_type"].Value = hour_typeComboBox.Text = publisher_field_service_reportDataGridView.CurrentRow.Cells["hour_type_actual"].FormattedValue.ToString().Trim();
            publisher_field_service_reportDataGridView.CurrentRow.Cells["privilege"].Value = privilegeTextBox.Text = publisher_field_service_reportDataGridView.CurrentRow.Cells["privilege_actual"].FormattedValue.ToString().Trim();
            publisher_field_service_reportDataGridView.CurrentRow.Cells["publisher_type"].Value = publisher_typeTextBox.Text = publisher_field_service_reportDataGridView.CurrentRow.Cells["publisher_type_actual"].FormattedValue.ToString().Trim();

            publisher_idTextBox.Text = id;
        }

        private void publisher_field_service_reportDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (publisher_field_service_reportDataGridView.CurrentRow == null)
            {
                return;
            }

            if (publisher_field_service_reportDataGridView.CurrentRow.Cells["date"].Value == DBNull.Value)
            {
                tbDateMask.Visible = true;
            }
            else
            {
                tbDateMask.Visible = false;
            }


            if (publisher_field_service_reportDataGridView.CurrentRow.Cells["report_date"].Value == DBNull.Value)
            {
                tbReportDateMask.Visible = true;
            }
            else
            {
                tbReportDateMask.Visible = false;
            }

            if (publisher_field_service_reportDataGridView.CurrentRow.Cells["publisher_name"].Value == null)
            {
                tbPublisherName.Clear();
            }
            else
            {
                tbPublisherName.Text = publisher_field_service_reportDataGridView.CurrentRow.Cells["publisher_name"].Value.ToString();
            }

            List<String> hour_types = new List<string>();
            hour_types.Add("Special Pioneer");
            hour_types.Add("Regular Pioneer");
            hour_types.Add("Auxiliary Pioneer");
            hour_types.Add("Publisher");

            hour_typeComboBox.SelectedIndex = hour_types.IndexOf(publisher_field_service_reportDataGridView.CurrentRow.Cells["hour_type"].FormattedValue.ToString().Trim());

            if (_dirtyTracker != null)
            {
                if (!isDirty)
                {
                    _dirtyTracker.MarkAsClean();
                }
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Singleton.fsrecords = null;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            bindingNavigator_ItemClicked = false;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (_dirtyTracker != null)
            {
                isDirty = _dirtyTracker.IsDirty ? true : false;
            }

            try
            {
                string filter = "";


                if (!tbDateFilterMask.Visible)
                {
                    if (filter.Length > 0) filter += "AND ";
                    filter += "date = '" + filterDateTimePicker.Value.Date.ToString() + "' ";
                }
                publisher_field_service_reportBindingSource.Filter = filter;
                loadDgv();
            }
            catch (Exception ex)
            {
                ex.sqlexception();
            }
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            tbDateFilterMask.Visible = true;
            publisher_field_service_reportBindingSource.Filter = "";

            loadDgv();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (publisher_field_service_reportDataGridView.RowCount < 1)
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
            if (publisher_field_service_reportDataGridView.RowCount < 1)
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

        internal void focusRow(String id)
        {
            int index = publisher_field_service_reportBindingSource.Find("publisher_field_service_report_id", id);

            if (index >= 0)
            {
                if (_dirtyTracker != null)
                {
                    focus_set = true;
                    isDirty = _dirtyTracker.IsDirty ? true : false;
                }
                publisher_field_service_reportBindingSource.Position = index;
            }
        }   

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            frmMessageBoxForm messageBox;
            if (publisher_field_service_reportDataGridView.SelectedRows.Count == 0)
            {
                messageBox = new frmMessageBoxForm("No rows selected");
                messageBox.ShowDialog();
                return;
            }
            else if (publisher_field_service_reportDataGridView.SelectedRows.Count == 1)
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
                    foreach (DataGridViewRow row in publisher_field_service_reportDataGridView.SelectedRows)
                    {
                        rowsDeleted = true;
                        bindingNavigator_ItemClicked = false;
                        publisher_field_service_reportDataGridView.Rows.RemoveAt(row.Index);

                    }
                    break;

                case DialogResult.No:
                    break;

                case DialogResult.Cancel:
                    break;
            }       
        }

        private void bindingNavigatorSeparator2_Click(object sender, EventArgs e)
        {
            bindingNavigator_ItemClicked = false;
        }

        private void publisher_field_service_reportBindingNavigator_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (_dirtyTracker != null)
            {
                bindingNavigator_ItemClicked = true;
                isDirty = _dirtyTracker.IsDirty ? true : false;
            }
        }

        private void publisher_field_service_reportDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (focus_set || bindingNavigator_ItemClicked || publisher_field_service_reportDataGridView.CurrentRow == null)
            {
                bindingNavigator_ItemClicked = false;
                focus_set = false;
                return;
            }

            if (_dirtyTracker != null)
            {
                isDirty = _dirtyTracker.IsDirty ? true : false;
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

        private void publisher_field_service_reportDataGridView_Sorted(object sender, EventArgs e)
        {
            if (_dirtyTracker != null)
            {
                bindingNavigator_ItemClicked = true;
                isDirty = _dirtyTracker.IsDirty ? true : false;
            }
            loadDgv();
        }

        private void dateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (publisher_field_service_reportDataGridView.CurrentRow == null)
            {
                return;
            }
            tbDateMask.Visible = false;
        }

        private void report_dateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (publisher_field_service_reportDataGridView.CurrentRow == null)
            {
                return;
            }
            tbReportDateMask.Visible = false;
        }

        private void bindingNavigatorCountItem_Click(object sender, EventArgs e)
        {
            bindingNavigator_ItemClicked = false;
        }

        private void bindingNavigatorSeparator1_Click(object sender, EventArgs e)
        {
            bindingNavigator_ItemClicked = false;
        }

        private void bindingNavigatorPositionItem_Click(object sender, EventArgs e)
        {
            bindingNavigator_ItemClicked = false;
        }

        private void filterDateTimePicker_CloseUp(object sender, EventArgs e)
        {
            tbDateFilterMask.Visible = false;
        }

        private void btnDate_Click(object sender, EventArgs e)
        {
            publisher_field_service_reportDataGridView.CurrentRow.Cells["date"].Value = DBNull.Value;
            tbDateMask.Visible = true;
        }

        private void btnReportDate_Click(object sender, EventArgs e)
        {
            publisher_field_service_reportDataGridView.CurrentRow.Cells["report_date"].Value = DBNull.Value;
            tbReportDateMask.Visible = true;
        }

        private void publisher_field_service_reportDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void btnChoosePublisher_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Singleton.ShowChoosePublisher();
        }

        private void tbDateMask_Click(object sender, EventArgs e)
        {
            tbDateMask.Visible = false;
        }

        private void tbReportDateMask_Click(object sender, EventArgs e)
        {
            tbReportDateMask.Visible = false;
        }
    }
}
