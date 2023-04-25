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
    public partial class frmFSRreport : Form
    {


        public frmFSRreport()
        {
            InitializeComponent();

            startDateTimePicker.Format = DateTimePickerFormat.Long;
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
        private void Label1_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void Label1_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void Label1_MouseUp(object sender, MouseEventArgs e)
        {
            
        }
        #endregion

        public bool EnforceConstraints { get; set; }
        private void publisher_field_service_report_Load(object sender, EventArgs e)
        {
            try
            {
                tMSADataSet.EnforceConstraints = false;
                this.publisher_field_service_report_viewTableAdapter.Fill(this.tMSADataSet.publisher_field_service_report_view);
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                this.Close();
                ex.sqlexception();
            }
        }

        private void Label1_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (Dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.StartPoint.X, p.Y - this.StartPoint.Y);
            }
        }

        private void Label1_MouseDown_1(object sender, MouseEventArgs e)
        {
            Dragging = true;
            StartPoint = new Point(e.X, e.Y);
        }

        private void Label1_MouseUp_1(object sender, MouseEventArgs e)
        {
            Dragging = false;
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reportViewer1_Hyperlink(object sender, Microsoft.Reporting.WinForms.HyperlinkEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Uri link = new Uri(e.Hyperlink);

            if (link.Authority == "csa")
            {
                e.Cancel = true; //Cancel the event to avoid opening the browser
                char[] sep = new char[] { '=' };
                var param = link.Query.Split(sep);
                string fs_record_id = param[1];
                Singleton.ShowFSrecord(fs_record_id);
            }
        }

        private void frmTabularAssignmentsReport_FormClosed(object sender, FormClosedEventArgs e)
        {
            Singleton.fsreport = null;
        }

        private void filter()
        {
            try
            {
                string filter = "";

                if (!string.IsNullOrEmpty(cmbGender.Text))
                {
                    filter += "gender = '" + cmbGender.Text.Trim() + "' ";
                }
                if (!string.IsNullOrEmpty(cmbPrivilege.Text))
                {
                    if (filter.Length > 0) filter += "AND ";
                    filter += "privilege = '" + cmbPrivilege.Text.Trim() + "' ";
                }
                if (!string.IsNullOrEmpty(cmbPubliserType.Text))
                {
                    if (filter.Length > 0) filter += "AND ";
                    filter += "publisher_type = '" + cmbPubliserType.Text.Trim() + "' ";
                }
                if (!string.IsNullOrEmpty(cmbHourType.Text))
                {
                    if (filter.Length > 0) filter += "AND ";
                    filter += "hour_type = '" + cmbHourType.Text.Trim() + "' ";
                }
                if (!string.IsNullOrEmpty(cmbGroup.Text))
                {
                    if (filter.Length > 0) filter += "AND ";
                    filter += "group = '" + cmbGroup.Text.Trim() + "' ";
                }
                if (!tbStartDateMask.Visible)
                {
                    if (filter.Length > 0) filter += "AND ";
                    filter += "date >= '" + startDateTimePicker.Value + "' ";
                }
                if (!tbEndDateMask.Visible)
                {
                    if (filter.Length > 0) filter += "AND ";
                    filter += "date <= '" + endDateTimePicker.Value + "' ";
                }
                if (filter.Length > 0) filter += "AND ";
                filter += "publisher_name LIKE '%" + txtSearch.Text + "%'";
                publisher_field_service_report_viewBindingSource.Filter = filter;
                this.reportViewer1.RefreshReport();

            }
            catch (Exception ex)
            {
                ex.sqlexception();
            }
        }

        private void fromDateTimePicker_CloseUp(object sender, EventArgs e)
        {
            tbStartDateMask.Visible = false;
        }    
        
        private void txtSearchPublisherName_TextChanged(object sender, EventArgs e)
        {
            filter();
        }

        private void txtSearchPublisherName_Enter(object sender, EventArgs e)
        {
            txtSearch.Clear();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtSearch_DoubleClick(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            txtSearch.Focus();
        }

        private void endDateTimePicker_CloseUp(object sender, EventArgs e)
        {
            tbEndDateMask.Visible = false;
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            publisher_field_service_report_viewBindingSource.Filter = "";
            this.reportViewer1.RefreshReport();
            txtSearch.Clear();

            cmbGender.SelectedIndex = 0;
            cmbPubliserType.SelectedIndex = 0;
            cmbHourType.SelectedIndex = 0;
            cmbPrivilege.SelectedIndex = 0;
            cmbGroup.SelectedIndex = 0;

            tbStartDateMask.Visible = true;
            tbEndDateMask.Visible = true;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            filter();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSearch_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtSearch.Clear();
        }

        private void tbStartDateMask_MouseClick(object sender, MouseEventArgs e)
        {
            tbStartDateMask.Visible = false;
        }

        private void tbEndDateMask_Click(object sender, EventArgs e)
        {
            tbEndDateMask.Visible = false;
        }

        private void btnStartMonthDel_Click(object sender, EventArgs e)
        {
            tbStartDateMask.Visible = true;
        }

        private void btnEndMonthDel_Click(object sender, EventArgs e)
        {
            tbEndDateMask.Visible = true;
        }

        private void startDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            tbStartDateMask.Visible = false;
        }

        private void endDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            tbEndDateMask.Visible = false;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                tMSADataSet.EnforceConstraints = false;
                this.publisher_field_service_report_viewTableAdapter.Fill(this.tMSADataSet.publisher_field_service_report_view);
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                this.Close();
                ex.sqlexception();
            }

            filter();
        }
    }
}
