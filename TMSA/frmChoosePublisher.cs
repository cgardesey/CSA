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
    public partial class frmChoosePublisher : Form
    {

        public frmChoosePublisher()
        {
            InitializeComponent();
        }


        private void frmChoosePublisher_Load(object sender, EventArgs e)
        {
            try
            {
                this.tMSADataSet.EnforceConstraints = false;
                this.publisher_last_field_service_report_viewTableAdapter.Fill(this.tMSADataSet.publisher_last_field_service_report_view);
            }
            catch (Exception ex)
            {
                this.Close();
                ex.sqlexception();
            }
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            //txtSearch.Text = "";
            //txtSearch.Focus();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            done();
        }

        private void tsReload_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                this.tMSADataSet.EnforceConstraints = false;
                this.publisher_last_field_service_report_viewTableAdapter.Fill(this.tMSADataSet.publisher_last_field_service_report_view);
            }
            catch (Exception ex)
            {
                ex.sqlexception();
            }
        }

        private void tsPublishers_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Singleton.ShowPublishers();
        }

        private void frmChoosePublisher_FormClosed(object sender, FormClosedEventArgs e)
        {
            Singleton.choosepublisher = null;
        }        

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            cmbGender.SelectedIndex = 0;
            cmbPubliserType.SelectedIndex = 0;
            cmbHourType.SelectedIndex = 0;
            cmbPrivilege.SelectedIndex = 0;
            cmbGroup.SelectedIndex = 0;
            try
            {
                string searchstring = txtSearch.Text;
                publisher_last_field_service_report_viewBindingSource.Filter = "publisher_name LIKE '%" + searchstring + "%'";
            }
            catch (Exception ex)
            {
                ex.sqlexception();
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            try
            {
                string filter = "";

                if (!string.IsNullOrEmpty(cmbGender.Text))
                {
                    filter += "gender = '" + cmbGender.Text + "' ";
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
                if (!string.IsNullOrEmpty(cmbGroup.Text))
                {
                    if (filter.Length > 0) filter += "AND ";
                    filter += "group = '" + cmbGroup.Text + "' ";
                }
                if (!string.IsNullOrEmpty(cmbHourType.Text))
                {
                    if (filter.Length > 0) filter += "AND ";
                    filter += "hour_type = '" + cmbHourType.Text + "' ";
                }                
                publisher_last_field_service_report_viewBindingSource.Filter = filter;

            }
            catch (Exception ex)
            {
                ex.sqlexception();
            }
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            publisher_last_field_service_report_viewBindingSource.Filter = "";
            txtSearch.Clear();
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


        private void done()
        {
            if (publisher_last_assignment_viewDataGridView.CurrentRow != null)
            {
                Singleton.fsrecords.onChoosePublisherCloseInit(publisher_last_assignment_viewDataGridView.CurrentRow.Cells["publisher_id"].Value.ToString());
            }
            this.Close();
        }

        private void publisher_last_assignment_viewDataGridView_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            toolTip1.SetToolTip(publisher_last_assignment_viewDataGridView, "Double-click row to select publisher.");
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                done();
            }
        }

        private void publisher_last_assignment_viewDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
