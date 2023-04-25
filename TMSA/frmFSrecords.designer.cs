
namespace TMSA
{
    partial class frmFSrecords
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
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label placementsLabel;
            System.Windows.Forms.Label videosLabel;
            System.Windows.Forms.Label hoursLabel;
            System.Windows.Forms.Label return_visitsLabel;
            System.Windows.Forms.Label bible_studiesLabel;
            System.Windows.Forms.Label report_dateLabel;
            System.Windows.Forms.Label hour_typeLabel;
            System.Windows.Forms.Label privilegeLabel;
            System.Windows.Forms.Label publisher_typeLabel;
            System.Windows.Forms.Label groupLabel;
            System.Windows.Forms.Label remarksLabel;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFSrecords));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tMSADataSet = new TMSA.TMSADataSet();
            this.publisher_field_service_reportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.publisher_field_service_reportTableAdapter = new TMSA.TMSADataSetTableAdapters.publisher_field_service_reportTableAdapter();
            this.tableAdapterManager = new TMSA.TMSADataSetTableAdapters.TableAdapterManager();
            this.publisherTableAdapter = new TMSA.TMSADataSetTableAdapters.publisherTableAdapter();
            this.publisher_field_service_reportBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.publisher_field_service_reportBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.publisher_field_service_reportDataGridView = new System.Windows.Forms.DataGridView();
            this.publisher_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisher_other_names = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.publisherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.publisher_last_name = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.group_actual = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.hour_type_actual = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.privilege_actual = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.publisher_type_actual = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hour_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.privilege = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisher_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.report_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.videos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.return_visits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bible_studies = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisher_idTextBox = new System.Windows.Forms.TextBox();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.placementsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.videosNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.hoursNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.return_visitsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.bible_studiesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.report_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.hour_typeComboBox = new System.Windows.Forms.ComboBox();
            this.privilegeTextBox = new System.Windows.Forms.TextBox();
            this.publisher_typeTextBox = new System.Windows.Forms.TextBox();
            this.groupTextBox = new System.Windows.Forms.TextBox();
            this.remarksTextBox = new System.Windows.Forms.TextBox();
            this.tbPublisherName = new System.Windows.Forms.TextBox();
            this.btnChoosePublisher = new System.Windows.Forms.Button();
            this.btnDate = new System.Windows.Forms.Button();
            this.btnReportDate = new System.Windows.Forms.Button();
            this.tbDateMask = new System.Windows.Forms.TextBox();
            this.tbReportDateMask = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClearFilter = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.tbDateFilterMask = new System.Windows.Forms.TextBox();
            this.filterDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            dateLabel = new System.Windows.Forms.Label();
            placementsLabel = new System.Windows.Forms.Label();
            videosLabel = new System.Windows.Forms.Label();
            hoursLabel = new System.Windows.Forms.Label();
            return_visitsLabel = new System.Windows.Forms.Label();
            bible_studiesLabel = new System.Windows.Forms.Label();
            report_dateLabel = new System.Windows.Forms.Label();
            hour_typeLabel = new System.Windows.Forms.Label();
            privilegeLabel = new System.Windows.Forms.Label();
            publisher_typeLabel = new System.Windows.Forms.Label();
            groupLabel = new System.Windows.Forms.Label();
            remarksLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tMSADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publisher_field_service_reportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publisher_field_service_reportBindingNavigator)).BeginInit();
            this.publisher_field_service_reportBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.publisher_field_service_reportDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publisherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.placementsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videosNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoursNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.return_visitsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bible_studiesNumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(46, 245);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(42, 17);
            dateLabel.TabIndex = 6;
            dateLabel.Text = "Date:";
            // 
            // placementsLabel
            // 
            placementsLabel.AutoSize = true;
            placementsLabel.Location = new System.Drawing.Point(46, 307);
            placementsLabel.Name = "placementsLabel";
            placementsLabel.Size = new System.Drawing.Size(85, 17);
            placementsLabel.TabIndex = 8;
            placementsLabel.Text = "Placements:";
            // 
            // videosLabel
            // 
            videosLabel.AutoSize = true;
            videosLabel.Location = new System.Drawing.Point(46, 338);
            videosLabel.Name = "videosLabel";
            videosLabel.Size = new System.Drawing.Size(55, 17);
            videosLabel.TabIndex = 10;
            videosLabel.Text = "Videos:";
            // 
            // hoursLabel
            // 
            hoursLabel.AutoSize = true;
            hoursLabel.Location = new System.Drawing.Point(46, 369);
            hoursLabel.Name = "hoursLabel";
            hoursLabel.Size = new System.Drawing.Size(50, 17);
            hoursLabel.TabIndex = 12;
            hoursLabel.Text = "Hours:";
            // 
            // return_visitsLabel
            // 
            return_visitsLabel.AutoSize = true;
            return_visitsLabel.Location = new System.Drawing.Point(46, 401);
            return_visitsLabel.Name = "return_visitsLabel";
            return_visitsLabel.Size = new System.Drawing.Size(90, 17);
            return_visitsLabel.TabIndex = 14;
            return_visitsLabel.Text = "Return visits:";
            // 
            // bible_studiesLabel
            // 
            bible_studiesLabel.AutoSize = true;
            bible_studiesLabel.Location = new System.Drawing.Point(46, 431);
            bible_studiesLabel.Name = "bible_studiesLabel";
            bible_studiesLabel.Size = new System.Drawing.Size(92, 17);
            bible_studiesLabel.TabIndex = 16;
            bible_studiesLabel.Text = "Bible studies:";
            // 
            // report_dateLabel
            // 
            report_dateLabel.AutoSize = true;
            report_dateLabel.Location = new System.Drawing.Point(46, 276);
            report_dateLabel.Name = "report_dateLabel";
            report_dateLabel.Size = new System.Drawing.Size(98, 17);
            report_dateLabel.TabIndex = 18;
            report_dateLabel.Text = "Report month:";
            // 
            // hour_typeLabel
            // 
            hour_typeLabel.AutoSize = true;
            hour_typeLabel.Location = new System.Drawing.Point(46, 213);
            hour_typeLabel.Name = "hour_typeLabel";
            hour_typeLabel.Size = new System.Drawing.Size(74, 17);
            hour_typeLabel.TabIndex = 20;
            hour_typeLabel.Text = "Hour type:";
            // 
            // privilegeLabel
            // 
            privilegeLabel.AutoSize = true;
            privilegeLabel.Location = new System.Drawing.Point(675, 404);
            privilegeLabel.Name = "privilegeLabel";
            privilegeLabel.Size = new System.Drawing.Size(66, 17);
            privilegeLabel.TabIndex = 22;
            privilegeLabel.Text = "Privilege:";
            // 
            // publisher_typeLabel
            // 
            publisher_typeLabel.AutoSize = true;
            publisher_typeLabel.Location = new System.Drawing.Point(675, 432);
            publisher_typeLabel.Name = "publisher_typeLabel";
            publisher_typeLabel.Size = new System.Drawing.Size(102, 17);
            publisher_typeLabel.TabIndex = 24;
            publisher_typeLabel.Text = "Publisher type:";
            // 
            // groupLabel
            // 
            groupLabel.AutoSize = true;
            groupLabel.Location = new System.Drawing.Point(675, 460);
            groupLabel.Name = "groupLabel";
            groupLabel.Size = new System.Drawing.Size(52, 17);
            groupLabel.TabIndex = 26;
            groupLabel.Text = "Group:";
            // 
            // remarksLabel
            // 
            remarksLabel.AutoSize = true;
            remarksLabel.Location = new System.Drawing.Point(46, 468);
            remarksLabel.Name = "remarksLabel";
            remarksLabel.Size = new System.Drawing.Size(68, 17);
            remarksLabel.TabIndex = 28;
            remarksLabel.Text = "Remarks:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(46, 183);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(71, 17);
            label1.TabIndex = 31;
            label1.Text = "Publisher:";
            // 
            // tMSADataSet
            // 
            this.tMSADataSet.DataSetName = "TMSADataSet";
            this.tMSADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // publisher_field_service_reportBindingSource
            // 
            this.publisher_field_service_reportBindingSource.DataMember = "publisher_field_service_report";
            this.publisher_field_service_reportBindingSource.DataSource = this.tMSADataSet;
            // 
            // publisher_field_service_reportTableAdapter
            // 
            this.publisher_field_service_reportTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.publisher_field_service_reportTableAdapter = this.publisher_field_service_reportTableAdapter;
            this.tableAdapterManager.publisherTableAdapter = this.publisherTableAdapter;
            this.tableAdapterManager.UpdateOrder = TMSA.TMSADataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // publisherTableAdapter
            // 
            this.publisherTableAdapter.ClearBeforeFill = true;
            // 
            // publisher_field_service_reportBindingNavigator
            // 
            this.publisher_field_service_reportBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.publisher_field_service_reportBindingNavigator.BindingSource = this.publisher_field_service_reportBindingSource;
            this.publisher_field_service_reportBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.publisher_field_service_reportBindingNavigator.DeleteItem = null;
            this.publisher_field_service_reportBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.publisher_field_service_reportBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.publisher_field_service_reportBindingNavigatorSaveItem});
            this.publisher_field_service_reportBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.publisher_field_service_reportBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.publisher_field_service_reportBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.publisher_field_service_reportBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.publisher_field_service_reportBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.publisher_field_service_reportBindingNavigator.Name = "publisher_field_service_reportBindingNavigator";
            this.publisher_field_service_reportBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.publisher_field_service_reportBindingNavigator.Size = new System.Drawing.Size(980, 27);
            this.publisher_field_service_reportBindingNavigator.TabIndex = 0;
            this.publisher_field_service_reportBindingNavigator.Text = "bindingNavigator1";
            this.publisher_field_service_reportBindingNavigator.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.publisher_field_service_reportBindingNavigator_ItemClicked);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            this.bindingNavigatorCountItem.Click += new System.EventHandler(this.bindingNavigatorCountItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(49, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            this.bindingNavigatorPositionItem.Click += new System.EventHandler(this.bindingNavigatorPositionItem_Click);
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            this.bindingNavigatorSeparator1.Click += new System.EventHandler(this.bindingNavigatorSeparator1_Click);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            this.bindingNavigatorSeparator2.Click += new System.EventHandler(this.bindingNavigatorSeparator2_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // publisher_field_service_reportBindingNavigatorSaveItem
            // 
            this.publisher_field_service_reportBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.publisher_field_service_reportBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("publisher_field_service_reportBindingNavigatorSaveItem.Image")));
            this.publisher_field_service_reportBindingNavigatorSaveItem.Name = "publisher_field_service_reportBindingNavigatorSaveItem";
            this.publisher_field_service_reportBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.publisher_field_service_reportBindingNavigatorSaveItem.Text = "Save Data";
            this.publisher_field_service_reportBindingNavigatorSaveItem.Click += new System.EventHandler(this.publisher_field_service_reportBindingNavigatorSaveItem_Click);
            // 
            // publisher_field_service_reportDataGridView
            // 
            this.publisher_field_service_reportDataGridView.AllowUserToAddRows = false;
            this.publisher_field_service_reportDataGridView.AllowUserToDeleteRows = false;
            this.publisher_field_service_reportDataGridView.AllowUserToOrderColumns = true;
            this.publisher_field_service_reportDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.publisher_field_service_reportDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.publisher_field_service_reportDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.publisher_field_service_reportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.publisher_field_service_reportDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.publisher_name,
            this.dataGridViewTextBoxColumn2,
            this.publisher_other_names,
            this.publisher_last_name,
            this.group_actual,
            this.hour_type_actual,
            this.privilege_actual,
            this.publisher_type_actual,
            this.group,
            this.hour_type,
            this.privilege,
            this.publisher_type,
            this.date,
            this.report_date,
            this.videos,
            this.hours,
            this.return_visits,
            this.bible_studies,
            this.remarks});
            this.publisher_field_service_reportDataGridView.DataSource = this.publisher_field_service_reportBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.publisher_field_service_reportDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.publisher_field_service_reportDataGridView.Location = new System.Drawing.Point(594, 180);
            this.publisher_field_service_reportDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.publisher_field_service_reportDataGridView.Name = "publisher_field_service_reportDataGridView";
            this.publisher_field_service_reportDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.publisher_field_service_reportDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.publisher_field_service_reportDataGridView.RowHeadersWidth = 51;
            this.publisher_field_service_reportDataGridView.RowTemplate.Height = 24;
            this.publisher_field_service_reportDataGridView.Size = new System.Drawing.Size(336, 413);
            this.publisher_field_service_reportDataGridView.TabIndex = 1;
            this.publisher_field_service_reportDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.publisher_field_service_reportDataGridView_DataError);
            this.publisher_field_service_reportDataGridView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.publisher_field_service_reportDataGridView_RowEnter);
            this.publisher_field_service_reportDataGridView.SelectionChanged += new System.EventHandler(this.publisher_field_service_reportDataGridView_SelectionChanged);
            this.publisher_field_service_reportDataGridView.Sorted += new System.EventHandler(this.publisher_field_service_reportDataGridView_Sorted);
            // 
            // publisher_name
            // 
            this.publisher_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.publisher_name.HeaderText = "Publisher Name";
            this.publisher_name.MinimumWidth = 110;
            this.publisher_name.Name = "publisher_name";
            this.publisher_name.ReadOnly = true;
            this.publisher_name.Width = 205;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "publisher_id";
            this.dataGridViewTextBoxColumn2.HeaderText = "publisher_id";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // publisher_other_names
            // 
            this.publisher_other_names.DataPropertyName = "publisher_id";
            this.publisher_other_names.DataSource = this.publisherBindingSource;
            this.publisher_other_names.DisplayMember = "other_names";
            this.publisher_other_names.HeaderText = "publisher_id";
            this.publisher_other_names.MinimumWidth = 6;
            this.publisher_other_names.Name = "publisher_other_names";
            this.publisher_other_names.ReadOnly = true;
            this.publisher_other_names.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.publisher_other_names.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.publisher_other_names.ValueMember = "publisher_id";
            this.publisher_other_names.Visible = false;
            this.publisher_other_names.Width = 125;
            // 
            // publisherBindingSource
            // 
            this.publisherBindingSource.DataMember = "publisher";
            this.publisherBindingSource.DataSource = this.tMSADataSet;
            // 
            // publisher_last_name
            // 
            this.publisher_last_name.DataPropertyName = "publisher_id";
            this.publisher_last_name.DataSource = this.publisherBindingSource;
            this.publisher_last_name.DisplayMember = "last_name";
            this.publisher_last_name.HeaderText = "publisher_id";
            this.publisher_last_name.MinimumWidth = 6;
            this.publisher_last_name.Name = "publisher_last_name";
            this.publisher_last_name.ReadOnly = true;
            this.publisher_last_name.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.publisher_last_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.publisher_last_name.ValueMember = "publisher_id";
            this.publisher_last_name.Visible = false;
            this.publisher_last_name.Width = 125;
            // 
            // group_actual
            // 
            this.group_actual.DataPropertyName = "publisher_id";
            this.group_actual.DataSource = this.publisherBindingSource;
            this.group_actual.DisplayMember = "group";
            this.group_actual.HeaderText = "group";
            this.group_actual.MinimumWidth = 6;
            this.group_actual.Name = "group_actual";
            this.group_actual.ReadOnly = true;
            this.group_actual.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.group_actual.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.group_actual.ValueMember = "publisher_id";
            this.group_actual.Visible = false;
            this.group_actual.Width = 125;
            // 
            // hour_type_actual
            // 
            this.hour_type_actual.DataPropertyName = "publisher_id";
            this.hour_type_actual.DataSource = this.publisherBindingSource;
            this.hour_type_actual.DisplayMember = "hour_type";
            this.hour_type_actual.HeaderText = "hour_type";
            this.hour_type_actual.MinimumWidth = 6;
            this.hour_type_actual.Name = "hour_type_actual";
            this.hour_type_actual.ReadOnly = true;
            this.hour_type_actual.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.hour_type_actual.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.hour_type_actual.ValueMember = "publisher_id";
            this.hour_type_actual.Visible = false;
            this.hour_type_actual.Width = 125;
            // 
            // privilege_actual
            // 
            this.privilege_actual.DataPropertyName = "publisher_id";
            this.privilege_actual.DataSource = this.publisherBindingSource;
            this.privilege_actual.DisplayMember = "privilege";
            this.privilege_actual.HeaderText = "privilege";
            this.privilege_actual.MinimumWidth = 6;
            this.privilege_actual.Name = "privilege_actual";
            this.privilege_actual.ReadOnly = true;
            this.privilege_actual.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.privilege_actual.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.privilege_actual.ValueMember = "publisher_id";
            this.privilege_actual.Visible = false;
            this.privilege_actual.Width = 125;
            // 
            // publisher_type_actual
            // 
            this.publisher_type_actual.DataPropertyName = "publisher_id";
            this.publisher_type_actual.DataSource = this.publisherBindingSource;
            this.publisher_type_actual.DisplayMember = "publisher_type";
            this.publisher_type_actual.HeaderText = "publisher_type";
            this.publisher_type_actual.MinimumWidth = 6;
            this.publisher_type_actual.Name = "publisher_type_actual";
            this.publisher_type_actual.ReadOnly = true;
            this.publisher_type_actual.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.publisher_type_actual.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.publisher_type_actual.ValueMember = "publisher_id";
            this.publisher_type_actual.Visible = false;
            this.publisher_type_actual.Width = 125;
            // 
            // group
            // 
            this.group.DataPropertyName = "group";
            this.group.HeaderText = "Group";
            this.group.MinimumWidth = 6;
            this.group.Name = "group";
            this.group.ReadOnly = true;
            this.group.Width = 125;
            // 
            // hour_type
            // 
            this.hour_type.DataPropertyName = "hour_type";
            this.hour_type.HeaderText = "Hour Type";
            this.hour_type.MinimumWidth = 6;
            this.hour_type.Name = "hour_type";
            this.hour_type.ReadOnly = true;
            this.hour_type.Width = 125;
            // 
            // privilege
            // 
            this.privilege.DataPropertyName = "privilege";
            this.privilege.HeaderText = "Privilege";
            this.privilege.MinimumWidth = 6;
            this.privilege.Name = "privilege";
            this.privilege.ReadOnly = true;
            this.privilege.Width = 125;
            // 
            // publisher_type
            // 
            this.publisher_type.DataPropertyName = "publisher_type";
            this.publisher_type.HeaderText = "Publisher Type";
            this.publisher_type.MinimumWidth = 6;
            this.publisher_type.Name = "publisher_type";
            this.publisher_type.ReadOnly = true;
            this.publisher_type.Width = 125;
            // 
            // date
            // 
            this.date.DataPropertyName = "date";
            this.date.HeaderText = "Date";
            this.date.MinimumWidth = 6;
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Width = 125;
            // 
            // report_date
            // 
            this.report_date.DataPropertyName = "report_date";
            this.report_date.HeaderText = "Month";
            this.report_date.MinimumWidth = 6;
            this.report_date.Name = "report_date";
            this.report_date.ReadOnly = true;
            this.report_date.Width = 125;
            // 
            // videos
            // 
            this.videos.DataPropertyName = "videos";
            this.videos.HeaderText = "Videos";
            this.videos.MinimumWidth = 6;
            this.videos.Name = "videos";
            this.videos.ReadOnly = true;
            this.videos.Width = 125;
            // 
            // hours
            // 
            this.hours.DataPropertyName = "hours";
            this.hours.HeaderText = "Hours";
            this.hours.MinimumWidth = 6;
            this.hours.Name = "hours";
            this.hours.ReadOnly = true;
            this.hours.Width = 125;
            // 
            // return_visits
            // 
            this.return_visits.DataPropertyName = "return_visits";
            this.return_visits.HeaderText = "Return Visits";
            this.return_visits.MinimumWidth = 6;
            this.return_visits.Name = "return_visits";
            this.return_visits.ReadOnly = true;
            this.return_visits.Width = 125;
            // 
            // bible_studies
            // 
            this.bible_studies.DataPropertyName = "bible_studies";
            this.bible_studies.HeaderText = "Bible Studies";
            this.bible_studies.MinimumWidth = 6;
            this.bible_studies.Name = "bible_studies";
            this.bible_studies.ReadOnly = true;
            this.bible_studies.Width = 125;
            // 
            // remarks
            // 
            this.remarks.DataPropertyName = "remarks";
            this.remarks.HeaderText = "Remarks";
            this.remarks.MinimumWidth = 6;
            this.remarks.Name = "remarks";
            this.remarks.ReadOnly = true;
            this.remarks.Width = 125;
            // 
            // publisher_idTextBox
            // 
            this.publisher_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.publisher_field_service_reportBindingSource, "publisher_id", true));
            this.publisher_idTextBox.Location = new System.Drawing.Point(329, 180);
            this.publisher_idTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.publisher_idTextBox.Name = "publisher_idTextBox";
            this.publisher_idTextBox.Size = new System.Drawing.Size(29, 22);
            this.publisher_idTextBox.TabIndex = 5;
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.publisher_field_service_reportBindingSource, "date", true));
            this.dateDateTimePicker.Location = new System.Drawing.Point(225, 244);
            this.dateDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(267, 22);
            this.dateDateTimePicker.TabIndex = 7;
            this.dateDateTimePicker.ValueChanged += new System.EventHandler(this.dateDateTimePicker_ValueChanged);
            // 
            // placementsNumericUpDown
            // 
            this.placementsNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.publisher_field_service_reportBindingSource, "placements", true));
            this.placementsNumericUpDown.Location = new System.Drawing.Point(224, 306);
            this.placementsNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.placementsNumericUpDown.Name = "placementsNumericUpDown";
            this.placementsNumericUpDown.Size = new System.Drawing.Size(267, 22);
            this.placementsNumericUpDown.TabIndex = 9;
            // 
            // videosNumericUpDown
            // 
            this.videosNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.publisher_field_service_reportBindingSource, "videos", true));
            this.videosNumericUpDown.Location = new System.Drawing.Point(224, 337);
            this.videosNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.videosNumericUpDown.Name = "videosNumericUpDown";
            this.videosNumericUpDown.Size = new System.Drawing.Size(267, 22);
            this.videosNumericUpDown.TabIndex = 11;
            // 
            // hoursNumericUpDown
            // 
            this.hoursNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.publisher_field_service_reportBindingSource, "hours", true));
            this.hoursNumericUpDown.DecimalPlaces = 2;
            this.hoursNumericUpDown.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.hoursNumericUpDown.Location = new System.Drawing.Point(224, 369);
            this.hoursNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hoursNumericUpDown.Name = "hoursNumericUpDown";
            this.hoursNumericUpDown.Size = new System.Drawing.Size(267, 22);
            this.hoursNumericUpDown.TabIndex = 13;
            // 
            // return_visitsNumericUpDown
            // 
            this.return_visitsNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.publisher_field_service_reportBindingSource, "return_visits", true));
            this.return_visitsNumericUpDown.Location = new System.Drawing.Point(224, 399);
            this.return_visitsNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.return_visitsNumericUpDown.Name = "return_visitsNumericUpDown";
            this.return_visitsNumericUpDown.Size = new System.Drawing.Size(267, 22);
            this.return_visitsNumericUpDown.TabIndex = 15;
            // 
            // bible_studiesNumericUpDown
            // 
            this.bible_studiesNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.publisher_field_service_reportBindingSource, "bible_studies", true));
            this.bible_studiesNumericUpDown.Location = new System.Drawing.Point(224, 430);
            this.bible_studiesNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bible_studiesNumericUpDown.Name = "bible_studiesNumericUpDown";
            this.bible_studiesNumericUpDown.Size = new System.Drawing.Size(267, 22);
            this.bible_studiesNumericUpDown.TabIndex = 17;
            // 
            // report_dateDateTimePicker
            // 
            this.report_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.publisher_field_service_reportBindingSource, "report_date", true));
            this.report_dateDateTimePicker.Location = new System.Drawing.Point(224, 275);
            this.report_dateDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.report_dateDateTimePicker.Name = "report_dateDateTimePicker";
            this.report_dateDateTimePicker.Size = new System.Drawing.Size(267, 22);
            this.report_dateDateTimePicker.TabIndex = 19;
            this.toolTip1.SetToolTip(this.report_dateDateTimePicker, "Please choose last day of moth as report month");
            this.report_dateDateTimePicker.ValueChanged += new System.EventHandler(this.report_dateDateTimePicker_ValueChanged);
            // 
            // hour_typeComboBox
            // 
            this.hour_typeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.publisher_field_service_reportBindingSource, "hour_type", true));
            this.hour_typeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hour_typeComboBox.FormattingEnabled = true;
            this.hour_typeComboBox.Items.AddRange(new object[] {
            "Special Pioneer",
            "Regular Pioneer",
            "Auxiliary Pioneer",
            "Publisher"});
            this.hour_typeComboBox.Location = new System.Drawing.Point(224, 211);
            this.hour_typeComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hour_typeComboBox.Name = "hour_typeComboBox";
            this.hour_typeComboBox.Size = new System.Drawing.Size(267, 24);
            this.hour_typeComboBox.TabIndex = 21;
            // 
            // privilegeTextBox
            // 
            this.privilegeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.publisher_field_service_reportBindingSource, "privilege", true));
            this.privilegeTextBox.Location = new System.Drawing.Point(781, 404);
            this.privilegeTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.privilegeTextBox.Name = "privilegeTextBox";
            this.privilegeTextBox.Size = new System.Drawing.Size(88, 22);
            this.privilegeTextBox.TabIndex = 23;
            // 
            // publisher_typeTextBox
            // 
            this.publisher_typeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.publisher_field_service_reportBindingSource, "publisher_type", true));
            this.publisher_typeTextBox.Location = new System.Drawing.Point(781, 432);
            this.publisher_typeTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.publisher_typeTextBox.Name = "publisher_typeTextBox";
            this.publisher_typeTextBox.Size = new System.Drawing.Size(88, 22);
            this.publisher_typeTextBox.TabIndex = 25;
            // 
            // groupTextBox
            // 
            this.groupTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.publisher_field_service_reportBindingSource, "group", true));
            this.groupTextBox.Location = new System.Drawing.Point(781, 460);
            this.groupTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupTextBox.Name = "groupTextBox";
            this.groupTextBox.Size = new System.Drawing.Size(88, 22);
            this.groupTextBox.TabIndex = 27;
            // 
            // remarksTextBox
            // 
            this.remarksTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.publisher_field_service_reportBindingSource, "remarks", true));
            this.remarksTextBox.Location = new System.Drawing.Point(224, 469);
            this.remarksTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.remarksTextBox.Multiline = true;
            this.remarksTextBox.Name = "remarksTextBox";
            this.remarksTextBox.Size = new System.Drawing.Size(265, 82);
            this.remarksTextBox.TabIndex = 29;
            // 
            // tbPublisherName
            // 
            this.tbPublisherName.Location = new System.Drawing.Point(224, 180);
            this.tbPublisherName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPublisherName.Name = "tbPublisherName";
            this.tbPublisherName.ReadOnly = true;
            this.tbPublisherName.Size = new System.Drawing.Size(268, 22);
            this.tbPublisherName.TabIndex = 30;
            // 
            // btnChoosePublisher
            // 
            this.btnChoosePublisher.Location = new System.Drawing.Point(494, 179);
            this.btnChoosePublisher.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChoosePublisher.Name = "btnChoosePublisher";
            this.btnChoosePublisher.Size = new System.Drawing.Size(50, 28);
            this.btnChoosePublisher.TabIndex = 32;
            this.btnChoosePublisher.Text = "...";
            this.btnChoosePublisher.UseVisualStyleBackColor = true;
            this.btnChoosePublisher.Click += new System.EventHandler(this.btnChoosePublisher_Click);
            // 
            // btnDate
            // 
            this.btnDate.Location = new System.Drawing.Point(494, 244);
            this.btnDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDate.Name = "btnDate";
            this.btnDate.Size = new System.Drawing.Size(50, 23);
            this.btnDate.TabIndex = 33;
            this.btnDate.Text = "DEL";
            this.btnDate.UseVisualStyleBackColor = true;
            this.btnDate.Click += new System.EventHandler(this.btnDate_Click);
            // 
            // btnReportDate
            // 
            this.btnReportDate.Location = new System.Drawing.Point(494, 275);
            this.btnReportDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReportDate.Name = "btnReportDate";
            this.btnReportDate.Size = new System.Drawing.Size(50, 23);
            this.btnReportDate.TabIndex = 34;
            this.btnReportDate.Text = "DEL";
            this.btnReportDate.UseVisualStyleBackColor = true;
            this.btnReportDate.Click += new System.EventHandler(this.btnReportDate_Click);
            // 
            // tbDateMask
            // 
            this.tbDateMask.Location = new System.Drawing.Point(225, 244);
            this.tbDateMask.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDateMask.Name = "tbDateMask";
            this.tbDateMask.ReadOnly = true;
            this.tbDateMask.Size = new System.Drawing.Size(224, 22);
            this.tbDateMask.TabIndex = 35;
            this.tbDateMask.Click += new System.EventHandler(this.tbDateMask_Click);
            // 
            // tbReportDateMask
            // 
            this.tbReportDateMask.Location = new System.Drawing.Point(224, 275);
            this.tbReportDateMask.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbReportDateMask.Name = "tbReportDateMask";
            this.tbReportDateMask.ReadOnly = true;
            this.tbReportDateMask.Size = new System.Drawing.Size(224, 22);
            this.tbReportDateMask.TabIndex = 36;
            this.tbReportDateMask.Click += new System.EventHandler(this.tbReportDateMask_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnClearFilter);
            this.groupBox1.Controls.Add(this.btnFilter);
            this.groupBox1.Controls.Add(this.tbDateFilterMask);
            this.groupBox1.Controls.Add(this.filterDateTimePicker);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(51, 64);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(879, 80);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter by:";
            // 
            // btnClearFilter
            // 
            this.btnClearFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearFilter.Location = new System.Drawing.Point(719, 26);
            this.btnClearFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClearFilter.Name = "btnClearFilter";
            this.btnClearFilter.Size = new System.Drawing.Size(119, 34);
            this.btnClearFilter.TabIndex = 40;
            this.btnClearFilter.Text = "Clear Filter";
            this.btnClearFilter.UseVisualStyleBackColor = true;
            this.btnClearFilter.Click += new System.EventHandler(this.btnClearFilter_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFilter.Location = new System.Drawing.Point(571, 26);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(119, 34);
            this.btnFilter.TabIndex = 39;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // tbDateFilterMask
            // 
            this.tbDateFilterMask.Location = new System.Drawing.Point(173, 30);
            this.tbDateFilterMask.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDateFilterMask.Name = "tbDateFilterMask";
            this.tbDateFilterMask.Size = new System.Drawing.Size(224, 22);
            this.tbDateFilterMask.TabIndex = 38;
            // 
            // filterDateTimePicker
            // 
            this.filterDateTimePicker.Location = new System.Drawing.Point(173, 30);
            this.filterDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.filterDateTimePicker.Name = "filterDateTimePicker";
            this.filterDateTimePicker.Size = new System.Drawing.Size(268, 22);
            this.filterDateTimePicker.TabIndex = 1;
            this.toolTip1.SetToolTip(this.filterDateTimePicker, "Please choose last day of moth as report month");
            this.filterDateTimePicker.CloseUp += new System.EventHandler(this.filterDateTimePicker_CloseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Report month:";
            // 
            // frmFSrecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 636);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.publisher_field_service_reportDataGridView);
            this.Controls.Add(this.tbReportDateMask);
            this.Controls.Add(this.tbDateMask);
            this.Controls.Add(this.btnReportDate);
            this.Controls.Add(this.btnDate);
            this.Controls.Add(this.btnChoosePublisher);
            this.Controls.Add(label1);
            this.Controls.Add(this.tbPublisherName);
            this.Controls.Add(this.publisher_idTextBox);
            this.Controls.Add(dateLabel);
            this.Controls.Add(this.dateDateTimePicker);
            this.Controls.Add(placementsLabel);
            this.Controls.Add(this.placementsNumericUpDown);
            this.Controls.Add(videosLabel);
            this.Controls.Add(this.videosNumericUpDown);
            this.Controls.Add(hoursLabel);
            this.Controls.Add(this.hoursNumericUpDown);
            this.Controls.Add(return_visitsLabel);
            this.Controls.Add(this.return_visitsNumericUpDown);
            this.Controls.Add(bible_studiesLabel);
            this.Controls.Add(this.bible_studiesNumericUpDown);
            this.Controls.Add(report_dateLabel);
            this.Controls.Add(this.report_dateDateTimePicker);
            this.Controls.Add(hour_typeLabel);
            this.Controls.Add(this.hour_typeComboBox);
            this.Controls.Add(privilegeLabel);
            this.Controls.Add(this.privilegeTextBox);
            this.Controls.Add(publisher_typeLabel);
            this.Controls.Add(this.publisher_typeTextBox);
            this.Controls.Add(groupLabel);
            this.Controls.Add(this.groupTextBox);
            this.Controls.Add(remarksLabel);
            this.Controls.Add(this.remarksTextBox);
            this.Controls.Add(this.publisher_field_service_reportBindingNavigator);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmFSrecords";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Field Service Records";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tMSADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publisher_field_service_reportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publisher_field_service_reportBindingNavigator)).EndInit();
            this.publisher_field_service_reportBindingNavigator.ResumeLayout(false);
            this.publisher_field_service_reportBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.publisher_field_service_reportDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publisherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.placementsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videosNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoursNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.return_visitsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bible_studiesNumericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TMSADataSet tMSADataSet;
        private System.Windows.Forms.BindingSource publisher_field_service_reportBindingSource;
        private TMSADataSetTableAdapters.publisher_field_service_reportTableAdapter publisher_field_service_reportTableAdapter;
        private TMSADataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator publisher_field_service_reportBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton publisher_field_service_reportBindingNavigatorSaveItem;
        private TMSADataSetTableAdapters.publisherTableAdapter publisherTableAdapter;
        private System.Windows.Forms.DataGridView publisher_field_service_reportDataGridView;
        private System.Windows.Forms.BindingSource publisherBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn placements;
        private System.Windows.Forms.TextBox publisher_idTextBox;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.NumericUpDown placementsNumericUpDown;
        private System.Windows.Forms.NumericUpDown videosNumericUpDown;
        private System.Windows.Forms.NumericUpDown hoursNumericUpDown;
        private System.Windows.Forms.NumericUpDown return_visitsNumericUpDown;
        private System.Windows.Forms.NumericUpDown bible_studiesNumericUpDown;
        private System.Windows.Forms.DateTimePicker report_dateDateTimePicker;
        private System.Windows.Forms.ComboBox hour_typeComboBox;
        private System.Windows.Forms.TextBox privilegeTextBox;
        private System.Windows.Forms.TextBox publisher_typeTextBox;
        private System.Windows.Forms.TextBox groupTextBox;
        private System.Windows.Forms.TextBox remarksTextBox;
        private System.Windows.Forms.TextBox tbPublisherName;
        private System.Windows.Forms.Button btnChoosePublisher;
        private System.Windows.Forms.Button btnDate;
        private System.Windows.Forms.Button btnReportDate;
        private System.Windows.Forms.TextBox tbDateMask;
        private System.Windows.Forms.TextBox tbReportDateMask;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClearFilter;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.TextBox tbDateFilterMask;
        private System.Windows.Forms.DateTimePicker filterDateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisher_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn publisher_other_names;
        private System.Windows.Forms.DataGridViewComboBoxColumn publisher_last_name;
        private System.Windows.Forms.DataGridViewComboBoxColumn group_actual;
        private System.Windows.Forms.DataGridViewComboBoxColumn hour_type_actual;
        private System.Windows.Forms.DataGridViewComboBoxColumn privilege_actual;
        private System.Windows.Forms.DataGridViewComboBoxColumn publisher_type_actual;
        private System.Windows.Forms.DataGridViewTextBoxColumn group;
        private System.Windows.Forms.DataGridViewTextBoxColumn hour_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn privilege;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisher_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn report_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn videos;
        private System.Windows.Forms.DataGridViewTextBoxColumn hours;
        private System.Windows.Forms.DataGridViewTextBoxColumn return_visits;
        private System.Windows.Forms.DataGridViewTextBoxColumn bible_studies;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarks;
    }
}