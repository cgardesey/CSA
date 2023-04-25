namespace TMSA
{
    partial class frmFSRreport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.publisher_field_service_report_viewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tMSADataSet = new TMSA.TMSADataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnEndMonthDel = new System.Windows.Forms.Button();
            this.tbEndDateMask = new System.Windows.Forms.TextBox();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStartMonthDel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbGroup = new System.Windows.Forms.ComboBox();
            this.cmbPrivilege = new System.Windows.Forms.ComboBox();
            this.tbStartDateMask = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbHourType = new System.Windows.Forms.ComboBox();
            this.cmbPubliserType = new System.Windows.Forms.ComboBox();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClearFilter = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.publisher_field_service_report_viewTableAdapter = new TMSA.TMSADataSetTableAdapters.publisher_field_service_report_viewTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.publisher_field_service_report_viewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMSADataSet)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // publisher_field_service_report_viewBindingSource
            // 
            this.publisher_field_service_report_viewBindingSource.DataMember = "publisher_field_service_report_view";
            this.publisher_field_service_report_viewBindingSource.DataSource = this.tMSADataSet;
            // 
            // tMSADataSet
            // 
            this.tMSADataSet.DataSetName = "TMSADataSet";
            this.tMSADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1248, 1);
            this.panel1.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1248, 132);
            this.panel3.TabIndex = 158;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.btnEndMonthDel);
            this.groupBox1.Controls.Add(this.tbEndDateMask);
            this.groupBox1.Controls.Add(this.endDateTimePicker);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnStartMonthDel);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbGroup);
            this.groupBox1.Controls.Add(this.cmbPrivilege);
            this.groupBox1.Controls.Add(this.tbStartDateMask);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.startDateTimePicker);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbHourType);
            this.groupBox1.Controls.Add(this.cmbPubliserType);
            this.groupBox1.Controls.Add(this.cmbGender);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnClearFilter);
            this.groupBox1.Controls.Add(this.btnFilter);
            this.groupBox1.Location = new System.Drawing.Point(12, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1224, 129);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter by:";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackColor = System.Drawing.Color.Orange;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(913, 93);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(110, 28);
            this.btnRefresh.TabIndex = 411;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(579, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(236, 23);
            this.label8.TabIndex = 410;
            this.label8.Text = "All or part of publisher name:";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.DimGray;
            this.txtSearch.Location = new System.Drawing.Point(583, 99);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(284, 23);
            this.txtSearch.TabIndex = 389;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtSearch_MouseDoubleClick);
            // 
            // btnEndMonthDel
            // 
            this.btnEndMonthDel.ForeColor = System.Drawing.Color.Black;
            this.btnEndMonthDel.Location = new System.Drawing.Point(523, 99);
            this.btnEndMonthDel.Name = "btnEndMonthDel";
            this.btnEndMonthDel.Size = new System.Drawing.Size(40, 23);
            this.btnEndMonthDel.TabIndex = 409;
            this.btnEndMonthDel.Text = "DEL";
            this.btnEndMonthDel.UseVisualStyleBackColor = true;
            this.btnEndMonthDel.Click += new System.EventHandler(this.btnEndMonthDel_Click);
            // 
            // tbEndDateMask
            // 
            this.tbEndDateMask.BackColor = System.Drawing.Color.White;
            this.tbEndDateMask.ForeColor = System.Drawing.Color.White;
            this.tbEndDateMask.Location = new System.Drawing.Point(309, 99);
            this.tbEndDateMask.Name = "tbEndDateMask";
            this.tbEndDateMask.ReadOnly = true;
            this.tbEndDateMask.Size = new System.Drawing.Size(194, 27);
            this.tbEndDateMask.TabIndex = 408;
            this.toolTip1.SetToolTip(this.tbEndDateMask, "Please choose last day of moth as report month");
            this.tbEndDateMask.Click += new System.EventHandler(this.tbEndDateMask_Click);
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.Location = new System.Drawing.Point(309, 99);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(212, 27);
            this.endDateTimePicker.TabIndex = 406;
            this.toolTip1.SetToolTip(this.endDateTimePicker, "Please choose last day of moth as report month");
            this.endDateTimePicker.Value = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.endDateTimePicker.ValueChanged += new System.EventHandler(this.endDateTimePicker_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(305, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 23);
            this.label1.TabIndex = 407;
            this.label1.Text = "End month:";
            // 
            // btnStartMonthDel
            // 
            this.btnStartMonthDel.ForeColor = System.Drawing.Color.Black;
            this.btnStartMonthDel.Location = new System.Drawing.Point(249, 99);
            this.btnStartMonthDel.Name = "btnStartMonthDel";
            this.btnStartMonthDel.Size = new System.Drawing.Size(40, 23);
            this.btnStartMonthDel.TabIndex = 405;
            this.btnStartMonthDel.Text = "DEL";
            this.btnStartMonthDel.UseVisualStyleBackColor = true;
            this.btnStartMonthDel.Click += new System.EventHandler(this.btnStartMonthDel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(700, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 23);
            this.label5.TabIndex = 401;
            this.label5.Text = "Privilege :";
            // 
            // cmbGroup
            // 
            this.cmbGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGroup.FormattingEnabled = true;
            this.cmbGroup.Items.AddRange(new object[] {
            "",
            "Group 1",
            "Group 2",
            "Group 3",
            "Group 4",
            "Group 5",
            "Group 6",
            "Group 7",
            "Group 8",
            "Group 9",
            "Group 10"});
            this.cmbGroup.Location = new System.Drawing.Point(945, 40);
            this.cmbGroup.Name = "cmbGroup";
            this.cmbGroup.Size = new System.Drawing.Size(78, 31);
            this.cmbGroup.TabIndex = 404;
            // 
            // cmbPrivilege
            // 
            this.cmbPrivilege.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrivilege.FormattingEnabled = true;
            this.cmbPrivilege.Items.AddRange(new object[] {
            "",
            "n/a",
            "Elder",
            "Ministerial Servant"});
            this.cmbPrivilege.Location = new System.Drawing.Point(704, 40);
            this.cmbPrivilege.Name = "cmbPrivilege";
            this.cmbPrivilege.Size = new System.Drawing.Size(140, 31);
            this.cmbPrivilege.TabIndex = 402;
            // 
            // tbStartDateMask
            // 
            this.tbStartDateMask.BackColor = System.Drawing.Color.White;
            this.tbStartDateMask.ForeColor = System.Drawing.Color.White;
            this.tbStartDateMask.Location = new System.Drawing.Point(35, 98);
            this.tbStartDateMask.Name = "tbStartDateMask";
            this.tbStartDateMask.ReadOnly = true;
            this.tbStartDateMask.Size = new System.Drawing.Size(194, 27);
            this.tbStartDateMask.TabIndex = 394;
            this.toolTip1.SetToolTip(this.tbStartDateMask, "Please choose last day of moth as report month");
            this.tbStartDateMask.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbStartDateMask_MouseClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(941, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 23);
            this.label6.TabIndex = 403;
            this.label6.Text = "Group :";
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.Location = new System.Drawing.Point(35, 98);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(212, 27);
            this.startDateTimePicker.TabIndex = 392;
            this.toolTip1.SetToolTip(this.startDateTimePicker, "Please choose last day of moth as report month");
            this.startDateTimePicker.Value = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.startDateTimePicker.ValueChanged += new System.EventHandler(this.startDateTimePicker_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(465, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 23);
            this.label7.TabIndex = 399;
            this.label7.Text = "Hour type :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(31, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 23);
            this.label4.TabIndex = 393;
            this.label4.Text = "Start month:";
            // 
            // cmbHourType
            // 
            this.cmbHourType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHourType.FormattingEnabled = true;
            this.cmbHourType.Items.AddRange(new object[] {
            "",
            "Special Pioneer",
            "Regular Pioneer",
            "Auxiliary Pioneer",
            "Publisher"});
            this.cmbHourType.Location = new System.Drawing.Point(469, 43);
            this.cmbHourType.Name = "cmbHourType";
            this.cmbHourType.Size = new System.Drawing.Size(134, 31);
            this.cmbHourType.TabIndex = 400;
            // 
            // cmbPubliserType
            // 
            this.cmbPubliserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPubliserType.FormattingEnabled = true;
            this.cmbPubliserType.Items.AddRange(new object[] {
            "",
            "Unbaptized Publisher",
            "Baptized Publisher"});
            this.cmbPubliserType.Location = new System.Drawing.Point(214, 43);
            this.cmbPubliserType.Name = "cmbPubliserType";
            this.cmbPubliserType.Size = new System.Drawing.Size(154, 31);
            this.cmbPubliserType.TabIndex = 398;
            // 
            // cmbGender
            // 
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "",
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(35, 43);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(78, 31);
            this.cmbGender.TabIndex = 396;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(210, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 23);
            this.label3.TabIndex = 397;
            this.label3.Text = "Publisher type :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(32, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 23);
            this.label2.TabIndex = 395;
            this.label2.Text = " Gender :";
            // 
            // btnClearFilter
            // 
            this.btnClearFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearFilter.BackColor = System.Drawing.Color.Orange;
            this.btnClearFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearFilter.ForeColor = System.Drawing.Color.White;
            this.btnClearFilter.Location = new System.Drawing.Point(1084, 93);
            this.btnClearFilter.Name = "btnClearFilter";
            this.btnClearFilter.Size = new System.Drawing.Size(110, 28);
            this.btnClearFilter.TabIndex = 391;
            this.btnClearFilter.Text = "Clear Filter";
            this.btnClearFilter.UseVisualStyleBackColor = false;
            this.btnClearFilter.Click += new System.EventHandler(this.btnClearFilter_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFilter.BackColor = System.Drawing.Color.Orange;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.ForeColor = System.Drawing.Color.White;
            this.btnFilter.Location = new System.Drawing.Point(1084, 43);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(110, 28);
            this.btnFilter.TabIndex = 390;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.publisher_field_service_report_viewBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.EnableHyperlinks = true;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TMSA.FSrecordReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, 139);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1246, 607);
            this.reportViewer1.TabIndex = 340;
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            this.reportViewer1.Hyperlink += new Microsoft.Reporting.WinForms.HyperlinkEventHandler(this.reportViewer1_Hyperlink);
            // 
            // publisher_field_service_report_viewTableAdapter
            // 
            this.publisher_field_service_report_viewTableAdapter.ClearBeforeFill = true;
            // 
            // frmFSRreport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1248, 746);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmFSRreport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Field Service Records Report";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmTabularAssignmentsReport_FormClosed);
            this.Load += new System.EventHandler(this.publisher_field_service_report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.publisher_field_service_report_viewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMSADataSet)).EndInit();
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button4;
        private TMSA.TMSADataSet tMSADataSet;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource publisher_field_service_report_viewBindingSource;
        private TMSADataSetTableAdapters.publisher_field_service_report_viewTableAdapter publisher_field_service_report_viewTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnEndMonthDel;
        private System.Windows.Forms.TextBox tbEndDateMask;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStartMonthDel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbGroup;
        private System.Windows.Forms.ComboBox cmbPrivilege;
        private System.Windows.Forms.TextBox tbStartDateMask;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbHourType;
        private System.Windows.Forms.ComboBox cmbPubliserType;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClearFilter;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnRefresh;
    }
}