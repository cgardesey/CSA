namespace TMSA
{
    partial class frmPublishers
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
            System.Windows.Forms.Label last_nameLabel;
            System.Windows.Forms.Label other_namesLabel;
            System.Windows.Forms.Label dobLabel;
            System.Windows.Forms.Label baptisam_dateLabel;
            System.Windows.Forms.Label contactLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label hour_typeLabel;
            System.Windows.Forms.Label privilegeLabel;
            System.Windows.Forms.Label publisher_typeLabel;
            System.Windows.Forms.Label groupLabel;
            System.Windows.Forms.Label hopeLabel;
            System.Windows.Forms.Label emergency_contactLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPublishers));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.publisherBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.publisherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tMSADataSet = new TMSA.TMSADataSet();
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
            this.publisherBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tsPublisherCards = new System.Windows.Forms.ToolStripButton();
            this.tsDeleteAssignments = new System.Windows.Forms.ToolStripButton();
            this.publisherDataGridView = new System.Windows.Forms.DataGridView();
            this.publisher_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.last_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.other_names = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baptisam_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.active = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hope = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisher_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hour_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.privilege = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.last_nameTextBox = new System.Windows.Forms.TextBox();
            this.other_namesTextBox = new System.Windows.Forms.TextBox();
            this.dobDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.baptisam_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.contactTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.activeCheckBox = new System.Windows.Forms.CheckBox();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.hour_typeComboBox = new System.Windows.Forms.ComboBox();
            this.privilegeComboBox = new System.Windows.Forms.ComboBox();
            this.publisher_typeComboBox = new System.Windows.Forms.ComboBox();
            this.groupComboBox = new System.Windows.Forms.ComboBox();
            this.hopeComboBox = new System.Windows.Forms.ComboBox();
            this.btnRemoveImage = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.picturePictureBox = new System.Windows.Forms.PictureBox();
            this.cmbHope = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbHourType = new System.Windows.Forms.ComboBox();
            this.cmbPubliserType = new System.Windows.Forms.ComboBox();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.tbBaptismDateMask = new System.Windows.Forms.TextBox();
            this.tbDobMask = new System.Windows.Forms.TextBox();
            this.btnBaptismDate = new System.Windows.Forms.Button();
            this.btnDob = new System.Windows.Forms.Button();
            this.btnClearFilter = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbGroup = new System.Windows.Forms.ComboBox();
            this.cmbPrivilege = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.publisher_field_service_report_viewDataGridView = new System.Windows.Forms.DataGridView();
            this._publisher_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._publisher_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._dob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._baptisam_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._active = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this._picture = new System.Windows.Forms.DataGridViewImageColumn();
            this._gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._hour_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._privilege = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._publisher_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._publisher_field_service_report_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._placements = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._videos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._hours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._return_visits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._bible_studies = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._report_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._hope = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisher_field_service_report_viewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.publisherTableAdapter = new TMSA.TMSADataSetTableAdapters.publisherTableAdapter();
            this.tableAdapterManager = new TMSA.TMSADataSetTableAdapters.TableAdapterManager();
            this.publisher_field_service_report_viewTableAdapter = new TMSA.TMSADataSetTableAdapters.publisher_field_service_report_viewTableAdapter();
            this.emergency_contactTextBox = new System.Windows.Forms.TextBox();
            last_nameLabel = new System.Windows.Forms.Label();
            other_namesLabel = new System.Windows.Forms.Label();
            dobLabel = new System.Windows.Forms.Label();
            baptisam_dateLabel = new System.Windows.Forms.Label();
            contactLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            hour_typeLabel = new System.Windows.Forms.Label();
            privilegeLabel = new System.Windows.Forms.Label();
            publisher_typeLabel = new System.Windows.Forms.Label();
            groupLabel = new System.Windows.Forms.Label();
            hopeLabel = new System.Windows.Forms.Label();
            emergency_contactLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.publisherBindingNavigator)).BeginInit();
            this.publisherBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.publisherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMSADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publisherDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.publisher_field_service_report_viewDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publisher_field_service_report_viewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // last_nameLabel
            // 
            last_nameLabel.AutoSize = true;
            last_nameLabel.Location = new System.Drawing.Point(63, 222);
            last_nameLabel.Name = "last_nameLabel";
            last_nameLabel.Size = new System.Drawing.Size(78, 17);
            last_nameLabel.TabIndex = 4;
            last_nameLabel.Text = "Last name:";
            // 
            // other_namesLabel
            // 
            other_namesLabel.AutoSize = true;
            other_namesLabel.Location = new System.Drawing.Point(63, 248);
            other_namesLabel.Name = "other_namesLabel";
            other_namesLabel.Size = new System.Drawing.Size(104, 17);
            other_namesLabel.TabIndex = 6;
            other_namesLabel.Text = "Other name(s):";
            // 
            // dobLabel
            // 
            dobLabel.AutoSize = true;
            dobLabel.Location = new System.Drawing.Point(64, 276);
            dobLabel.Name = "dobLabel";
            dobLabel.Size = new System.Drawing.Size(91, 17);
            dobLabel.TabIndex = 8;
            dobLabel.Text = "Date of Birth:";
            // 
            // baptisam_dateLabel
            // 
            baptisam_dateLabel.AutoSize = true;
            baptisam_dateLabel.Location = new System.Drawing.Point(64, 305);
            baptisam_dateLabel.Name = "baptisam_dateLabel";
            baptisam_dateLabel.Size = new System.Drawing.Size(94, 17);
            baptisam_dateLabel.TabIndex = 10;
            baptisam_dateLabel.Text = "Baptism date:";
            // 
            // contactLabel
            // 
            contactLabel.AutoSize = true;
            contactLabel.Location = new System.Drawing.Point(63, 332);
            contactLabel.Name = "contactLabel";
            contactLabel.Size = new System.Drawing.Size(60, 17);
            contactLabel.TabIndex = 12;
            contactLabel.Text = "Contact:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(65, 421);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(64, 17);
            addressLabel.TabIndex = 14;
            addressLabel.Text = "Address:";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new System.Drawing.Point(63, 499);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(60, 17);
            genderLabel.TabIndex = 18;
            genderLabel.Text = "Gender:";
            // 
            // hour_typeLabel
            // 
            hour_typeLabel.AutoSize = true;
            hour_typeLabel.Location = new System.Drawing.Point(64, 591);
            hour_typeLabel.Name = "hour_typeLabel";
            hour_typeLabel.Size = new System.Drawing.Size(74, 17);
            hour_typeLabel.TabIndex = 20;
            hour_typeLabel.Text = "Hour type:";
            // 
            // privilegeLabel
            // 
            privilegeLabel.AutoSize = true;
            privilegeLabel.Location = new System.Drawing.Point(63, 620);
            privilegeLabel.Name = "privilegeLabel";
            privilegeLabel.Size = new System.Drawing.Size(66, 17);
            privilegeLabel.TabIndex = 22;
            privilegeLabel.Text = "Privilege:";
            // 
            // publisher_typeLabel
            // 
            publisher_typeLabel.AutoSize = true;
            publisher_typeLabel.Location = new System.Drawing.Point(63, 560);
            publisher_typeLabel.Name = "publisher_typeLabel";
            publisher_typeLabel.Size = new System.Drawing.Size(102, 17);
            publisher_typeLabel.TabIndex = 24;
            publisher_typeLabel.Text = "Publisher type:";
            // 
            // groupLabel
            // 
            groupLabel.AutoSize = true;
            groupLabel.Location = new System.Drawing.Point(63, 650);
            groupLabel.Name = "groupLabel";
            groupLabel.Size = new System.Drawing.Size(52, 17);
            groupLabel.TabIndex = 26;
            groupLabel.Text = "Group:";
            // 
            // hopeLabel
            // 
            hopeLabel.AutoSize = true;
            hopeLabel.Location = new System.Drawing.Point(64, 530);
            hopeLabel.Name = "hopeLabel";
            hopeLabel.Size = new System.Drawing.Size(46, 17);
            hopeLabel.TabIndex = 30;
            hopeLabel.Text = "Hope:";
            // 
            // emergency_contactLabel
            // 
            emergency_contactLabel.Location = new System.Drawing.Point(63, 355);
            emergency_contactLabel.Name = "emergency_contactLabel";
            emergency_contactLabel.Size = new System.Drawing.Size(92, 34);
            emergency_contactLabel.TabIndex = 203;
            emergency_contactLabel.Text = "Emergency Contact:";
            // 
            // publisherBindingNavigator
            // 
            this.publisherBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.publisherBindingNavigator.BindingSource = this.publisherBindingSource;
            this.publisherBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.publisherBindingNavigator.DeleteItem = null;
            this.publisherBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.publisherBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.publisherBindingNavigatorSaveItem,
            this.tsPublisherCards,
            this.tsDeleteAssignments});
            this.publisherBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.publisherBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.publisherBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.publisherBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.publisherBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.publisherBindingNavigator.Name = "publisherBindingNavigator";
            this.publisherBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.publisherBindingNavigator.Size = new System.Drawing.Size(1292, 27);
            this.publisherBindingNavigator.TabIndex = 0;
            this.publisherBindingNavigator.Text = "bindingNavigator1";
            this.publisherBindingNavigator.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.publisherBindingNavigator_ItemClicked);
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
            // publisherBindingSource
            // 
            this.publisherBindingSource.DataMember = "publisher";
            this.publisherBindingSource.DataSource = this.tMSADataSet;
            // 
            // tMSADataSet
            // 
            this.tMSADataSet.DataSetName = "TMSADataSet";
            this.tMSADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
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
            this.bindingNavigatorDeleteItem.EnabledChanged += new System.EventHandler(this.bindingNavigatorDeleteItem_EnabledChanged);
            // 
            // publisherBindingNavigatorSaveItem
            // 
            this.publisherBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.publisherBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("publisherBindingNavigatorSaveItem.Image")));
            this.publisherBindingNavigatorSaveItem.Name = "publisherBindingNavigatorSaveItem";
            this.publisherBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.publisherBindingNavigatorSaveItem.Text = "Save Data";
            this.publisherBindingNavigatorSaveItem.Click += new System.EventHandler(this.publisherBindingNavigatorSaveItem_Click);
            // 
            // tsPublisherCards
            // 
            this.tsPublisherCards.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsPublisherCards.Image = ((System.Drawing.Image)(resources.GetObject("tsPublisherCards.Image")));
            this.tsPublisherCards.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsPublisherCards.Name = "tsPublisherCards";
            this.tsPublisherCards.Size = new System.Drawing.Size(29, 24);
            this.tsPublisherCards.Text = "Publisher record cards";
            this.tsPublisherCards.Click += new System.EventHandler(this.tsPublisherCards_Click);
            // 
            // tsDeleteAssignments
            // 
            this.tsDeleteAssignments.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsDeleteAssignments.Image = ((System.Drawing.Image)(resources.GetObject("tsDeleteAssignments.Image")));
            this.tsDeleteAssignments.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsDeleteAssignments.Name = "tsDeleteAssignments";
            this.tsDeleteAssignments.Size = new System.Drawing.Size(29, 24);
            this.tsDeleteAssignments.Text = "Delete selected publisher\'s field service records";
            this.tsDeleteAssignments.Click += new System.EventHandler(this.tsDeleteAssignments_Click_1);
            // 
            // publisherDataGridView
            // 
            this.publisherDataGridView.AllowUserToAddRows = false;
            this.publisherDataGridView.AllowUserToDeleteRows = false;
            this.publisherDataGridView.AllowUserToOrderColumns = true;
            this.publisherDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.publisherDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.publisherDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.publisherDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.publisherDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.publisher_id,
            this.last_name,
            this.other_names,
            this.dob,
            this.baptisam_date,
            this.contact,
            this.address,
            this.active,
            this.gender,
            this.hope,
            this.publisher_type,
            this.hour_type,
            this.privilege,
            this.group});
            this.publisherDataGridView.DataSource = this.publisherBindingSource;
            this.publisherDataGridView.Location = new System.Drawing.Point(790, 218);
            this.publisherDataGridView.Name = "publisherDataGridView";
            this.publisherDataGridView.ReadOnly = true;
            this.publisherDataGridView.RowHeadersWidth = 51;
            this.publisherDataGridView.RowTemplate.Height = 24;
            this.publisherDataGridView.Size = new System.Drawing.Size(431, 452);
            this.publisherDataGridView.TabIndex = 1;
            this.publisherDataGridView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.publisherDataGridView_RowEnter);
            this.publisherDataGridView.SelectionChanged += new System.EventHandler(this.publisherDataGridView_SelectionChanged);
            // 
            // publisher_id
            // 
            this.publisher_id.DataPropertyName = "publisher_id";
            this.publisher_id.HeaderText = "publisher_id";
            this.publisher_id.MinimumWidth = 6;
            this.publisher_id.Name = "publisher_id";
            this.publisher_id.ReadOnly = true;
            this.publisher_id.Visible = false;
            this.publisher_id.Width = 105;
            // 
            // last_name
            // 
            this.last_name.DataPropertyName = "last_name";
            this.last_name.HeaderText = "Last Name";
            this.last_name.MinimumWidth = 6;
            this.last_name.Name = "last_name";
            this.last_name.ReadOnly = true;
            this.last_name.Width = 112;
            // 
            // other_names
            // 
            this.other_names.DataPropertyName = "other_names";
            this.other_names.HeaderText = "Other Name(s)";
            this.other_names.MinimumWidth = 6;
            this.other_names.Name = "other_names";
            this.other_names.ReadOnly = true;
            this.other_names.Width = 186;
            // 
            // dob
            // 
            this.dob.DataPropertyName = "dob";
            this.dob.HeaderText = "Date of Birth";
            this.dob.MinimumWidth = 6;
            this.dob.Name = "dob";
            this.dob.ReadOnly = true;
            this.dob.Width = 125;
            // 
            // baptisam_date
            // 
            this.baptisam_date.DataPropertyName = "baptisam_date";
            this.baptisam_date.HeaderText = "Baptism Date";
            this.baptisam_date.MinimumWidth = 6;
            this.baptisam_date.Name = "baptisam_date";
            this.baptisam_date.ReadOnly = true;
            this.baptisam_date.Width = 125;
            // 
            // contact
            // 
            this.contact.DataPropertyName = "contact";
            this.contact.HeaderText = "Contact";
            this.contact.MinimumWidth = 6;
            this.contact.Name = "contact";
            this.contact.ReadOnly = true;
            this.contact.Width = 125;
            // 
            // address
            // 
            this.address.DataPropertyName = "address";
            this.address.HeaderText = "Address";
            this.address.MinimumWidth = 6;
            this.address.Name = "address";
            this.address.ReadOnly = true;
            this.address.Width = 125;
            // 
            // active
            // 
            this.active.DataPropertyName = "active";
            this.active.HeaderText = "To Be Skipped";
            this.active.MinimumWidth = 6;
            this.active.Name = "active";
            this.active.ReadOnly = true;
            this.active.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.active.Width = 125;
            // 
            // gender
            // 
            this.gender.DataPropertyName = "gender";
            this.gender.HeaderText = "Gender";
            this.gender.MinimumWidth = 6;
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            this.gender.Width = 125;
            // 
            // hope
            // 
            this.hope.DataPropertyName = "hope";
            this.hope.HeaderText = "Hope";
            this.hope.MinimumWidth = 6;
            this.hope.Name = "hope";
            this.hope.ReadOnly = true;
            this.hope.Width = 125;
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
            // group
            // 
            this.group.DataPropertyName = "group";
            this.group.HeaderText = "Group";
            this.group.MinimumWidth = 6;
            this.group.Name = "group";
            this.group.ReadOnly = true;
            this.group.Width = 125;
            // 
            // last_nameTextBox
            // 
            this.last_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.publisherBindingSource, "last_name", true));
            this.last_nameTextBox.Location = new System.Drawing.Point(171, 218);
            this.last_nameTextBox.Name = "last_nameTextBox";
            this.last_nameTextBox.Size = new System.Drawing.Size(265, 22);
            this.last_nameTextBox.TabIndex = 5;
            this.last_nameTextBox.Click += new System.EventHandler(this.last_nameTextBox_Click);
            // 
            // other_namesTextBox
            // 
            this.other_namesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.publisherBindingSource, "other_names", true));
            this.other_namesTextBox.Location = new System.Drawing.Point(170, 246);
            this.other_namesTextBox.Name = "other_namesTextBox";
            this.other_namesTextBox.Size = new System.Drawing.Size(265, 22);
            this.other_namesTextBox.TabIndex = 7;
            this.other_namesTextBox.Click += new System.EventHandler(this.other_namesTextBox_Click);
            // 
            // dobDateTimePicker
            // 
            this.dobDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.publisherBindingSource, "dob", true));
            this.dobDateTimePicker.Location = new System.Drawing.Point(171, 273);
            this.dobDateTimePicker.Name = "dobDateTimePicker";
            this.dobDateTimePicker.Size = new System.Drawing.Size(265, 22);
            this.dobDateTimePicker.TabIndex = 9;
            this.dobDateTimePicker.ValueChanged += new System.EventHandler(this.dobDateTimePicker_ValueChanged);
            // 
            // baptisam_dateDateTimePicker
            // 
            this.baptisam_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.publisherBindingSource, "baptisam_date", true));
            this.baptisam_dateDateTimePicker.Location = new System.Drawing.Point(171, 302);
            this.baptisam_dateDateTimePicker.Name = "baptisam_dateDateTimePicker";
            this.baptisam_dateDateTimePicker.Size = new System.Drawing.Size(265, 22);
            this.baptisam_dateDateTimePicker.TabIndex = 11;
            this.baptisam_dateDateTimePicker.ValueChanged += new System.EventHandler(this.baptisam_dateDateTimePicker_ValueChanged);
            // 
            // contactTextBox
            // 
            this.contactTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.publisherBindingSource, "contact", true));
            this.contactTextBox.Location = new System.Drawing.Point(170, 331);
            this.contactTextBox.Name = "contactTextBox";
            this.contactTextBox.Size = new System.Drawing.Size(265, 22);
            this.contactTextBox.TabIndex = 13;
            this.contactTextBox.Click += new System.EventHandler(this.contactTextBox_Click);
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.publisherBindingSource, "address", true));
            this.addressTextBox.Location = new System.Drawing.Point(170, 385);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(265, 82);
            this.addressTextBox.TabIndex = 15;
            this.addressTextBox.Click += new System.EventHandler(this.addressTextBox_Click);
            // 
            // activeCheckBox
            // 
            this.activeCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.publisherBindingSource, "active", true));
            this.activeCheckBox.Location = new System.Drawing.Point(170, 470);
            this.activeCheckBox.Name = "activeCheckBox";
            this.activeCheckBox.Size = new System.Drawing.Size(200, 24);
            this.activeCheckBox.TabIndex = 17;
            this.activeCheckBox.Text = "To be skipped";
            this.activeCheckBox.UseVisualStyleBackColor = true;
            // 
            // genderComboBox
            // 
            this.genderComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.publisherBindingSource, "gender", true));
            this.genderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.genderComboBox.Location = new System.Drawing.Point(170, 495);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(265, 24);
            this.genderComboBox.TabIndex = 19;
            // 
            // hour_typeComboBox
            // 
            this.hour_typeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.publisherBindingSource, "hour_type", true));
            this.hour_typeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hour_typeComboBox.FormattingEnabled = true;
            this.hour_typeComboBox.Items.AddRange(new object[] {
            "Special Pioneer",
            "Regular Pioneer",
            "Auxiliary Pioneer",
            "Publisher"});
            this.hour_typeComboBox.Location = new System.Drawing.Point(171, 586);
            this.hour_typeComboBox.Name = "hour_typeComboBox";
            this.hour_typeComboBox.Size = new System.Drawing.Size(265, 24);
            this.hour_typeComboBox.TabIndex = 21;
            // 
            // privilegeComboBox
            // 
            this.privilegeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.publisherBindingSource, "privilege", true));
            this.privilegeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.privilegeComboBox.FormattingEnabled = true;
            this.privilegeComboBox.Items.AddRange(new object[] {
            "n/a",
            "Non",
            "Elder",
            "Ministerial Servant"});
            this.privilegeComboBox.Location = new System.Drawing.Point(170, 616);
            this.privilegeComboBox.Name = "privilegeComboBox";
            this.privilegeComboBox.Size = new System.Drawing.Size(265, 24);
            this.privilegeComboBox.TabIndex = 23;
            // 
            // publisher_typeComboBox
            // 
            this.publisher_typeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.publisherBindingSource, "publisher_type", true));
            this.publisher_typeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.publisher_typeComboBox.FormattingEnabled = true;
            this.publisher_typeComboBox.Items.AddRange(new object[] {
            "Unbaptized Publisher",
            "Baptized Publisher"});
            this.publisher_typeComboBox.Location = new System.Drawing.Point(170, 556);
            this.publisher_typeComboBox.Name = "publisher_typeComboBox";
            this.publisher_typeComboBox.Size = new System.Drawing.Size(265, 24);
            this.publisher_typeComboBox.TabIndex = 25;
            // 
            // groupComboBox
            // 
            this.groupComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.publisherBindingSource, "group", true));
            this.groupComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.groupComboBox.FormattingEnabled = true;
            this.groupComboBox.Items.AddRange(new object[] {
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
            this.groupComboBox.Location = new System.Drawing.Point(170, 646);
            this.groupComboBox.Name = "groupComboBox";
            this.groupComboBox.Size = new System.Drawing.Size(265, 24);
            this.groupComboBox.TabIndex = 27;
            this.groupComboBox.Click += new System.EventHandler(this.groupComboBox_Click);
            // 
            // hopeComboBox
            // 
            this.hopeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.publisherBindingSource, "hope", true));
            this.hopeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hopeComboBox.FormattingEnabled = true;
            this.hopeComboBox.Items.AddRange(new object[] {
            "Anointed",
            "Other sheep"});
            this.hopeComboBox.Location = new System.Drawing.Point(171, 526);
            this.hopeComboBox.Name = "hopeComboBox";
            this.hopeComboBox.Size = new System.Drawing.Size(265, 24);
            this.hopeComboBox.TabIndex = 31;
            // 
            // btnRemoveImage
            // 
            this.btnRemoveImage.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnRemoveImage.BackColor = System.Drawing.SystemColors.Control;
            this.btnRemoveImage.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.btnRemoveImage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.btnRemoveImage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnRemoveImage.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRemoveImage.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveImage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRemoveImage.Location = new System.Drawing.Point(513, 500);
            this.btnRemoveImage.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveImage.Name = "btnRemoveImage";
            this.btnRemoveImage.Size = new System.Drawing.Size(227, 46);
            this.btnRemoveImage.TabIndex = 194;
            this.btnRemoveImage.Text = "&Remove Image";
            this.btnRemoveImage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRemoveImage.UseVisualStyleBackColor = false;
            this.btnRemoveImage.Click += new System.EventHandler(this.btnRemoveImage_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 30);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 17);
            this.label6.TabIndex = 348;
            this.label6.Text = " Hope :";
            // 
            // picturePictureBox
            // 
            this.picturePictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picturePictureBox.BackgroundImage")));
            this.picturePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picturePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.publisherBindingSource, "picture", true));
            this.picturePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("picturePictureBox.Image")));
            this.picturePictureBox.Location = new System.Drawing.Point(513, 219);
            this.picturePictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.picturePictureBox.Name = "picturePictureBox";
            this.picturePictureBox.Size = new System.Drawing.Size(223, 219);
            this.picturePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturePictureBox.TabIndex = 195;
            this.picturePictureBox.TabStop = false;
            // 
            // cmbHope
            // 
            this.cmbHope.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHope.FormattingEnabled = true;
            this.cmbHope.Items.AddRange(new object[] {
            "",
            "Anointed",
            "Other sheep"});
            this.cmbHope.Location = new System.Drawing.Point(35, 49);
            this.cmbHope.Margin = new System.Windows.Forms.Padding(4);
            this.cmbHope.Name = "cmbHope";
            this.cmbHope.Size = new System.Drawing.Size(96, 24);
            this.cmbHope.TabIndex = 349;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(427, 30);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 17);
            this.label7.TabIndex = 346;
            this.label7.Text = "Hour type :";
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
            this.cmbHourType.Location = new System.Drawing.Point(431, 49);
            this.cmbHourType.Margin = new System.Windows.Forms.Padding(4);
            this.cmbHourType.Name = "cmbHourType";
            this.cmbHourType.Size = new System.Drawing.Size(164, 24);
            this.cmbHourType.TabIndex = 347;
            // 
            // cmbPubliserType
            // 
            this.cmbPubliserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPubliserType.FormattingEnabled = true;
            this.cmbPubliserType.Items.AddRange(new object[] {
            "",
            "Unbaptized Publisher",
            "Baptized Publisher"});
            this.cmbPubliserType.Location = new System.Drawing.Point(253, 49);
            this.cmbPubliserType.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPubliserType.Name = "cmbPubliserType";
            this.cmbPubliserType.Size = new System.Drawing.Size(164, 24);
            this.cmbPubliserType.TabIndex = 177;
            // 
            // cmbGender
            // 
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "",
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(144, 49);
            this.cmbGender.Margin = new System.Windows.Forms.Padding(4);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(96, 24);
            this.cmbGender.TabIndex = 173;
            // 
            // tbBaptismDateMask
            // 
            this.tbBaptismDateMask.BackColor = System.Drawing.Color.White;
            this.tbBaptismDateMask.ForeColor = System.Drawing.Color.White;
            this.tbBaptismDateMask.Location = new System.Drawing.Point(171, 302);
            this.tbBaptismDateMask.Margin = new System.Windows.Forms.Padding(4);
            this.tbBaptismDateMask.Name = "tbBaptismDateMask";
            this.tbBaptismDateMask.ReadOnly = true;
            this.tbBaptismDateMask.Size = new System.Drawing.Size(224, 22);
            this.tbBaptismDateMask.TabIndex = 198;
            this.tbBaptismDateMask.Visible = false;
            this.tbBaptismDateMask.Click += new System.EventHandler(this.tbBaptismDateMask_Click);
            // 
            // tbDobMask
            // 
            this.tbDobMask.BackColor = System.Drawing.Color.White;
            this.tbDobMask.ForeColor = System.Drawing.Color.White;
            this.tbDobMask.Location = new System.Drawing.Point(171, 273);
            this.tbDobMask.Margin = new System.Windows.Forms.Padding(4);
            this.tbDobMask.Name = "tbDobMask";
            this.tbDobMask.ReadOnly = true;
            this.tbDobMask.Size = new System.Drawing.Size(224, 22);
            this.tbDobMask.TabIndex = 199;
            this.tbDobMask.Visible = false;
            this.tbDobMask.Click += new System.EventHandler(this.tbDobMask_Click);
            // 
            // btnBaptismDate
            // 
            this.btnBaptismDate.Location = new System.Drawing.Point(443, 297);
            this.btnBaptismDate.Margin = new System.Windows.Forms.Padding(4);
            this.btnBaptismDate.Name = "btnBaptismDate";
            this.btnBaptismDate.Size = new System.Drawing.Size(57, 28);
            this.btnBaptismDate.TabIndex = 196;
            this.btnBaptismDate.Text = "DEL";
            this.btnBaptismDate.UseVisualStyleBackColor = true;
            this.btnBaptismDate.Click += new System.EventHandler(this.btnBaptismDate_Click);
            // 
            // btnDob
            // 
            this.btnDob.Location = new System.Drawing.Point(443, 270);
            this.btnDob.Margin = new System.Windows.Forms.Padding(4);
            this.btnDob.Name = "btnDob";
            this.btnDob.Size = new System.Drawing.Size(57, 28);
            this.btnDob.TabIndex = 197;
            this.btnDob.Text = "DEL";
            this.btnDob.UseVisualStyleBackColor = true;
            this.btnDob.Click += new System.EventHandler(this.btnDob_Click);
            // 
            // btnClearFilter
            // 
            this.btnClearFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearFilter.BackColor = System.Drawing.SystemColors.Control;
            this.btnClearFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearFilter.Location = new System.Drawing.Point(1015, 43);
            this.btnClearFilter.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearFilter.Name = "btnClearFilter";
            this.btnClearFilter.Size = new System.Drawing.Size(119, 34);
            this.btnClearFilter.TabIndex = 345;
            this.btnClearFilter.Text = "Clear Filter";
            this.btnClearFilter.UseVisualStyleBackColor = false;
            this.btnClearFilter.Click += new System.EventHandler(this.btnClearFilter_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFilter.BackColor = System.Drawing.SystemColors.Control;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Location = new System.Drawing.Point(888, 43);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(4);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(119, 34);
            this.btnFilter.TabIndex = 344;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(31, 23);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(367, 22);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.DoubleClick += new System.EventHandler(this.txtSearch_DoubleClick);
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.MouseEnter += new System.EventHandler(this.txtSearch_MouseEnter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(249, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 176;
            this.label3.Text = "Publisher type :";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cmbHope);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cmbHourType);
            this.groupBox1.Controls.Add(this.btnClearFilter);
            this.groupBox1.Controls.Add(this.btnFilter);
            this.groupBox1.Controls.Add(this.cmbPubliserType);
            this.groupBox1.Controls.Add(this.cmbGender);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbGroup);
            this.groupBox1.Controls.Add(this.cmbPrivilege);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(56, 49);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1159, 93);
            this.groupBox1.TabIndex = 200;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter by:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(604, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 170;
            this.label1.Text = "Privilege :";
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
            this.cmbGroup.Location = new System.Drawing.Point(785, 49);
            this.cmbGroup.Margin = new System.Windows.Forms.Padding(4);
            this.cmbGroup.Name = "cmbGroup";
            this.cmbGroup.Size = new System.Drawing.Size(95, 24);
            this.cmbGroup.TabIndex = 175;
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
            this.cmbPrivilege.Location = new System.Drawing.Point(608, 49);
            this.cmbPrivilege.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPrivilege.Name = "cmbPrivilege";
            this.cmbPrivilege.Size = new System.Drawing.Size(164, 24);
            this.cmbPrivilege.TabIndex = 171;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(781, 30);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 174;
            this.label4.Text = "Group :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 172;
            this.label2.Text = " Gender :";
            // 
            // btnBrowse
            // 
            this.btnBrowse.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnBrowse.BackColor = System.Drawing.SystemColors.Control;
            this.btnBrowse.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.btnBrowse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.btnBrowse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBrowse.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBrowse.Location = new System.Drawing.Point(513, 446);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(224, 46);
            this.btnBrowse.TabIndex = 193;
            this.btnBrowse.Text = "&Browse Image";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txtSearch);
            this.groupBox2.Location = new System.Drawing.Point(790, 150);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(425, 62);
            this.groupBox2.TabIndex = 201;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filter by publisher";
            // 
            // publisher_field_service_report_viewDataGridView
            // 
            this.publisher_field_service_report_viewDataGridView.AutoGenerateColumns = false;
            this.publisher_field_service_report_viewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.publisher_field_service_report_viewDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._publisher_id,
            this._publisher_name,
            this._dob,
            this._baptisam_date,
            this._contact,
            this._address,
            this._active,
            this._picture,
            this._gender,
            this._hour_type,
            this._privilege,
            this._publisher_type,
            this._group,
            this._publisher_field_service_report_id,
            this._date,
            this._placements,
            this._videos,
            this._hours,
            this._return_visits,
            this._bible_studies,
            this._report_date,
            this._remarks,
            this._hope});
            this.publisher_field_service_report_viewDataGridView.DataSource = this.publisher_field_service_report_viewBindingSource;
            this.publisher_field_service_report_viewDataGridView.Location = new System.Drawing.Point(870, 406);
            this.publisher_field_service_report_viewDataGridView.Name = "publisher_field_service_report_viewDataGridView";
            this.publisher_field_service_report_viewDataGridView.RowHeadersWidth = 51;
            this.publisher_field_service_report_viewDataGridView.RowTemplate.Height = 24;
            this.publisher_field_service_report_viewDataGridView.Size = new System.Drawing.Size(300, 101);
            this.publisher_field_service_report_viewDataGridView.TabIndex = 201;
            this.publisher_field_service_report_viewDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.publisher_field_service_report_viewDataGridView_DataError);
            // 
            // _publisher_id
            // 
            this._publisher_id.DataPropertyName = "publisher_id";
            this._publisher_id.HeaderText = "publisher_id";
            this._publisher_id.MinimumWidth = 6;
            this._publisher_id.Name = "_publisher_id";
            this._publisher_id.Width = 125;
            // 
            // _publisher_name
            // 
            this._publisher_name.DataPropertyName = "publisher_name";
            this._publisher_name.HeaderText = "publisher_name";
            this._publisher_name.MinimumWidth = 6;
            this._publisher_name.Name = "_publisher_name";
            this._publisher_name.ReadOnly = true;
            this._publisher_name.Width = 125;
            // 
            // _dob
            // 
            this._dob.DataPropertyName = "dob";
            this._dob.HeaderText = "dob";
            this._dob.MinimumWidth = 6;
            this._dob.Name = "_dob";
            this._dob.Width = 125;
            // 
            // _baptisam_date
            // 
            this._baptisam_date.DataPropertyName = "baptisam_date";
            this._baptisam_date.HeaderText = "baptisam_date";
            this._baptisam_date.MinimumWidth = 6;
            this._baptisam_date.Name = "_baptisam_date";
            this._baptisam_date.Width = 125;
            // 
            // _contact
            // 
            this._contact.DataPropertyName = "contact";
            this._contact.HeaderText = "contact";
            this._contact.MinimumWidth = 6;
            this._contact.Name = "_contact";
            this._contact.Width = 125;
            // 
            // _address
            // 
            this._address.DataPropertyName = "address";
            this._address.HeaderText = "address";
            this._address.MinimumWidth = 6;
            this._address.Name = "_address";
            this._address.Width = 125;
            // 
            // _active
            // 
            this._active.DataPropertyName = "active";
            this._active.HeaderText = "active";
            this._active.MinimumWidth = 6;
            this._active.Name = "_active";
            this._active.Width = 125;
            // 
            // _picture
            // 
            this._picture.DataPropertyName = "picture";
            this._picture.HeaderText = "picture";
            this._picture.MinimumWidth = 6;
            this._picture.Name = "_picture";
            this._picture.Width = 125;
            // 
            // _gender
            // 
            this._gender.DataPropertyName = "gender";
            this._gender.HeaderText = "gender";
            this._gender.MinimumWidth = 6;
            this._gender.Name = "_gender";
            this._gender.Width = 125;
            // 
            // _hour_type
            // 
            this._hour_type.DataPropertyName = "hour_type";
            this._hour_type.HeaderText = "hour_type";
            this._hour_type.MinimumWidth = 6;
            this._hour_type.Name = "_hour_type";
            this._hour_type.Width = 125;
            // 
            // _privilege
            // 
            this._privilege.DataPropertyName = "privilege";
            this._privilege.HeaderText = "privilege";
            this._privilege.MinimumWidth = 6;
            this._privilege.Name = "_privilege";
            this._privilege.Width = 125;
            // 
            // _publisher_type
            // 
            this._publisher_type.DataPropertyName = "publisher_type";
            this._publisher_type.HeaderText = "publisher_type";
            this._publisher_type.MinimumWidth = 6;
            this._publisher_type.Name = "_publisher_type";
            this._publisher_type.Width = 125;
            // 
            // _group
            // 
            this._group.DataPropertyName = "group";
            this._group.HeaderText = "group";
            this._group.MinimumWidth = 6;
            this._group.Name = "_group";
            this._group.Width = 125;
            // 
            // _publisher_field_service_report_id
            // 
            this._publisher_field_service_report_id.DataPropertyName = "publisher_field_service_report_id";
            this._publisher_field_service_report_id.HeaderText = "publisher_field_service_report_id";
            this._publisher_field_service_report_id.MinimumWidth = 6;
            this._publisher_field_service_report_id.Name = "_publisher_field_service_report_id";
            this._publisher_field_service_report_id.Width = 125;
            // 
            // _date
            // 
            this._date.DataPropertyName = "date";
            this._date.HeaderText = "date";
            this._date.MinimumWidth = 6;
            this._date.Name = "_date";
            this._date.Width = 125;
            // 
            // _placements
            // 
            this._placements.DataPropertyName = "placements";
            this._placements.HeaderText = "placements";
            this._placements.MinimumWidth = 6;
            this._placements.Name = "_placements";
            this._placements.Width = 125;
            // 
            // _videos
            // 
            this._videos.DataPropertyName = "videos";
            this._videos.HeaderText = "videos";
            this._videos.MinimumWidth = 6;
            this._videos.Name = "_videos";
            this._videos.Width = 125;
            // 
            // _hours
            // 
            this._hours.DataPropertyName = "hours";
            this._hours.HeaderText = "hours";
            this._hours.MinimumWidth = 6;
            this._hours.Name = "_hours";
            this._hours.Width = 125;
            // 
            // _return_visits
            // 
            this._return_visits.DataPropertyName = "return_visits";
            this._return_visits.HeaderText = "return_visits";
            this._return_visits.MinimumWidth = 6;
            this._return_visits.Name = "_return_visits";
            this._return_visits.Width = 125;
            // 
            // _bible_studies
            // 
            this._bible_studies.DataPropertyName = "bible_studies";
            this._bible_studies.HeaderText = "bible_studies";
            this._bible_studies.MinimumWidth = 6;
            this._bible_studies.Name = "_bible_studies";
            this._bible_studies.Width = 125;
            // 
            // _report_date
            // 
            this._report_date.DataPropertyName = "report_date";
            this._report_date.HeaderText = "report_date";
            this._report_date.MinimumWidth = 6;
            this._report_date.Name = "_report_date";
            this._report_date.Width = 125;
            // 
            // _remarks
            // 
            this._remarks.DataPropertyName = "remarks";
            this._remarks.HeaderText = "remarks";
            this._remarks.MinimumWidth = 6;
            this._remarks.Name = "_remarks";
            this._remarks.Width = 125;
            // 
            // _hope
            // 
            this._hope.DataPropertyName = "hope";
            this._hope.HeaderText = "hope";
            this._hope.MinimumWidth = 6;
            this._hope.Name = "_hope";
            this._hope.Width = 125;
            // 
            // publisher_field_service_report_viewBindingSource
            // 
            this.publisher_field_service_report_viewBindingSource.DataMember = "publisher_field_service_report_view";
            this.publisher_field_service_report_viewBindingSource.DataSource = this.tMSADataSet;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // publisherTableAdapter
            // 
            this.publisherTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.publisher_field_service_reportTableAdapter = null;
            this.tableAdapterManager.publisherTableAdapter = this.publisherTableAdapter;
            this.tableAdapterManager.UpdateOrder = TMSA.TMSADataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // publisher_field_service_report_viewTableAdapter
            // 
            this.publisher_field_service_report_viewTableAdapter.ClearBeforeFill = true;
            // 
            // emergency_contactTextBox
            // 
            this.emergency_contactTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.publisherBindingSource, "emergency_contact", true));
            this.emergency_contactTextBox.Location = new System.Drawing.Point(170, 358);
            this.emergency_contactTextBox.Name = "emergency_contactTextBox";
            this.emergency_contactTextBox.Size = new System.Drawing.Size(265, 22);
            this.emergency_contactTextBox.TabIndex = 204;
            // 
            // frmPublishers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 703);
            this.Controls.Add(emergency_contactLabel);
            this.Controls.Add(this.emergency_contactTextBox);
            this.Controls.Add(this.publisherDataGridView);
            this.Controls.Add(this.btnRemoveImage);
            this.Controls.Add(this.picturePictureBox);
            this.Controls.Add(this.tbBaptismDateMask);
            this.Controls.Add(this.tbDobMask);
            this.Controls.Add(this.btnBaptismDate);
            this.Controls.Add(this.btnDob);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(hopeLabel);
            this.Controls.Add(this.hopeComboBox);
            this.Controls.Add(last_nameLabel);
            this.Controls.Add(this.last_nameTextBox);
            this.Controls.Add(other_namesLabel);
            this.Controls.Add(this.other_namesTextBox);
            this.Controls.Add(dobLabel);
            this.Controls.Add(this.dobDateTimePicker);
            this.Controls.Add(baptisam_dateLabel);
            this.Controls.Add(this.baptisam_dateDateTimePicker);
            this.Controls.Add(contactLabel);
            this.Controls.Add(this.contactTextBox);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.activeCheckBox);
            this.Controls.Add(genderLabel);
            this.Controls.Add(this.genderComboBox);
            this.Controls.Add(hour_typeLabel);
            this.Controls.Add(this.hour_typeComboBox);
            this.Controls.Add(privilegeLabel);
            this.Controls.Add(this.privilegeComboBox);
            this.Controls.Add(publisher_typeLabel);
            this.Controls.Add(this.publisher_typeComboBox);
            this.Controls.Add(groupLabel);
            this.Controls.Add(this.groupComboBox);
            this.Controls.Add(this.publisherBindingNavigator);
            this.Controls.Add(this.publisher_field_service_report_viewDataGridView);
            this.Name = "frmPublishers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Publishers";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.publisherBindingNavigator)).EndInit();
            this.publisherBindingNavigator.ResumeLayout(false);
            this.publisherBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.publisherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMSADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publisherDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.publisher_field_service_report_viewDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publisher_field_service_report_viewBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TMSADataSet tMSADataSet;
        private System.Windows.Forms.BindingSource publisherBindingSource;
        private TMSADataSetTableAdapters.publisherTableAdapter publisherTableAdapter;
        private TMSADataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator publisherBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton publisherBindingNavigatorSaveItem;
        public System.Windows.Forms.DataGridView publisherDataGridView;
        private System.Windows.Forms.TextBox last_nameTextBox;
        private System.Windows.Forms.TextBox other_namesTextBox;
        private System.Windows.Forms.DateTimePicker dobDateTimePicker;
        private System.Windows.Forms.DateTimePicker baptisam_dateDateTimePicker;
        private System.Windows.Forms.TextBox contactTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.CheckBox activeCheckBox;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.ComboBox hour_typeComboBox;
        private System.Windows.Forms.ComboBox privilegeComboBox;
        private System.Windows.Forms.ComboBox publisher_typeComboBox;
        private System.Windows.Forms.ComboBox groupComboBox;
        private System.Windows.Forms.ComboBox hopeComboBox;
        internal System.Windows.Forms.Button btnRemoveImage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox picturePictureBox;
        private System.Windows.Forms.ComboBox cmbHope;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbHourType;
        private System.Windows.Forms.ComboBox cmbPubliserType;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.TextBox tbBaptismDateMask;
        private System.Windows.Forms.TextBox tbDobMask;
        private System.Windows.Forms.Button btnBaptismDate;
        private System.Windows.Forms.Button btnDob;
        private System.Windows.Forms.Button btnClearFilter;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbGroup;
        private System.Windows.Forms.ComboBox cmbPrivilege;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStripButton tsPublisherCards;
        private System.Windows.Forms.ToolStripButton tsDeleteAssignments;
        public System.Windows.Forms.BindingSource publisher_field_service_report_viewBindingSource;
        private TMSADataSetTableAdapters.publisher_field_service_report_viewTableAdapter publisher_field_service_report_viewTableAdapter;
        public System.Windows.Forms.DataGridView publisher_field_service_report_viewDataGridView;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn _publisher_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn _publisher_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn _dob;
        private System.Windows.Forms.DataGridViewTextBoxColumn _baptisam_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn _contact;
        private System.Windows.Forms.DataGridViewTextBoxColumn _address;
        private System.Windows.Forms.DataGridViewCheckBoxColumn _active;
        private System.Windows.Forms.DataGridViewImageColumn _picture;
        private System.Windows.Forms.DataGridViewTextBoxColumn _gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn _hour_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn _privilege;
        private System.Windows.Forms.DataGridViewTextBoxColumn _publisher_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn _group;
        private System.Windows.Forms.DataGridViewTextBoxColumn _publisher_field_service_report_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn _date;
        private System.Windows.Forms.DataGridViewTextBoxColumn _placements;
        private System.Windows.Forms.DataGridViewTextBoxColumn _videos;
        private System.Windows.Forms.DataGridViewTextBoxColumn _hours;
        private System.Windows.Forms.DataGridViewTextBoxColumn _return_visits;
        private System.Windows.Forms.DataGridViewTextBoxColumn _bible_studies;
        private System.Windows.Forms.DataGridViewTextBoxColumn _report_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn _remarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn _hope;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisher_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn last_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn other_names;
        private System.Windows.Forms.DataGridViewTextBoxColumn dob;
        private System.Windows.Forms.DataGridViewTextBoxColumn baptisam_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn contact;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewCheckBoxColumn active;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn hope;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisher_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn hour_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn privilege;
        private System.Windows.Forms.DataGridViewTextBoxColumn group;
        private System.Windows.Forms.TextBox emergency_contactTextBox;
    }
}