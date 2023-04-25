namespace TMSA
{
    partial class frmChoosePublisher
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
            System.Windows.Forms.Label publisher_groupLabel;
            System.Windows.Forms.Label publisher_typeLabel;
            System.Windows.Forms.Label publisher_privilegeLabel;
            System.Windows.Forms.Label publisher_genderLabel;
            System.Windows.Forms.Label publisher_nameLabel;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label8;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChoosePublisher));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.publisher_last_assignment_viewBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.publisher_last_field_service_report_viewBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.tsReload = new System.Windows.Forms.ToolStripButton();
            this.tsPublishers = new System.Windows.Forms.ToolStripButton();
            this.btnDone = new System.Windows.Forms.Button();
            this.picturePictureBox = new System.Windows.Forms.PictureBox();
            this.publisher_groupTextBox = new System.Windows.Forms.TextBox();
            this.publisher_typeTextBox = new System.Windows.Forms.TextBox();
            this.publisher_privilegeTextBox = new System.Windows.Forms.TextBox();
            this.publisher_genderTextBox = new System.Windows.Forms.TextBox();
            this.publisher_nameTextBox = new System.Windows.Forms.TextBox();
            this.publisher_last_assignment_viewDataGridView = new System.Windows.Forms.DataGridView();
            this.publisher_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisher_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hourtypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.privilegeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publishertypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbHourType = new System.Windows.Forms.ComboBox();
            this.btnClearFilter = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.cmbPubliserType = new System.Windows.Forms.ComboBox();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbGroup = new System.Windows.Forms.ComboBox();
            this.cmbPrivilege = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tableAdapterManager = new TMSA.TMSADataSetTableAdapters.TableAdapterManager();
            this.publisher_last_field_service_report_viewTableAdapter = new TMSA.TMSADataSetTableAdapters.publisher_last_field_service_report_viewTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            publisher_groupLabel = new System.Windows.Forms.Label();
            publisher_typeLabel = new System.Windows.Forms.Label();
            publisher_privilegeLabel = new System.Windows.Forms.Label();
            publisher_genderLabel = new System.Windows.Forms.Label();
            publisher_nameLabel = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.publisher_last_assignment_viewBindingNavigator)).BeginInit();
            this.publisher_last_assignment_viewBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.publisher_last_field_service_report_viewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMSADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publisher_last_assignment_viewDataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // publisher_groupLabel
            // 
            publisher_groupLabel.AutoSize = true;
            publisher_groupLabel.Location = new System.Drawing.Point(48, 443);
            publisher_groupLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            publisher_groupLabel.Name = "publisher_groupLabel";
            publisher_groupLabel.Size = new System.Drawing.Size(52, 17);
            publisher_groupLabel.TabIndex = 237;
            publisher_groupLabel.Text = "Group:";
            // 
            // publisher_typeLabel
            // 
            publisher_typeLabel.AutoSize = true;
            publisher_typeLabel.Location = new System.Drawing.Point(49, 372);
            publisher_typeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            publisher_typeLabel.Name = "publisher_typeLabel";
            publisher_typeLabel.Size = new System.Drawing.Size(102, 17);
            publisher_typeLabel.TabIndex = 235;
            publisher_typeLabel.Text = "Publisher type:";
            // 
            // publisher_privilegeLabel
            // 
            publisher_privilegeLabel.AutoSize = true;
            publisher_privilegeLabel.Location = new System.Drawing.Point(49, 331);
            publisher_privilegeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            publisher_privilegeLabel.Name = "publisher_privilegeLabel";
            publisher_privilegeLabel.Size = new System.Drawing.Size(66, 17);
            publisher_privilegeLabel.TabIndex = 233;
            publisher_privilegeLabel.Text = "Privilege:";
            // 
            // publisher_genderLabel
            // 
            publisher_genderLabel.AutoSize = true;
            publisher_genderLabel.Location = new System.Drawing.Point(49, 290);
            publisher_genderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            publisher_genderLabel.Name = "publisher_genderLabel";
            publisher_genderLabel.Size = new System.Drawing.Size(60, 17);
            publisher_genderLabel.TabIndex = 231;
            publisher_genderLabel.Text = "Gender:";
            // 
            // publisher_nameLabel
            // 
            publisher_nameLabel.AutoSize = true;
            publisher_nameLabel.Location = new System.Drawing.Point(49, 250);
            publisher_nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            publisher_nameLabel.Name = "publisher_nameLabel";
            publisher_nameLabel.Size = new System.Drawing.Size(110, 17);
            publisher_nameLabel.TabIndex = 221;
            publisher_nameLabel.Text = "Publisher name:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(51, 514);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(113, 17);
            label6.TabIndex = 250;
            label6.Text = "Last report date:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(48, 411);
            label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(74, 17);
            label8.TabIndex = 252;
            label8.Text = "Hour type:";
            // 
            // publisher_last_assignment_viewBindingNavigator
            // 
            this.publisher_last_assignment_viewBindingNavigator.AddNewItem = null;
            this.publisher_last_assignment_viewBindingNavigator.BindingSource = this.publisher_last_field_service_report_viewBindingSource;
            this.publisher_last_assignment_viewBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.publisher_last_assignment_viewBindingNavigator.DeleteItem = null;
            this.publisher_last_assignment_viewBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.publisher_last_assignment_viewBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.tsReload,
            this.tsPublishers});
            this.publisher_last_assignment_viewBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.publisher_last_assignment_viewBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.publisher_last_assignment_viewBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.publisher_last_assignment_viewBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.publisher_last_assignment_viewBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.publisher_last_assignment_viewBindingNavigator.Name = "publisher_last_assignment_viewBindingNavigator";
            this.publisher_last_assignment_viewBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.publisher_last_assignment_viewBindingNavigator.Size = new System.Drawing.Size(1129, 27);
            this.publisher_last_assignment_viewBindingNavigator.TabIndex = 1;
            this.publisher_last_assignment_viewBindingNavigator.Text = "bindingNavigator1";
            // 
            // publisher_last_field_service_report_viewBindingSource
            // 
            this.publisher_last_field_service_report_viewBindingSource.DataMember = "publisher_last_field_service_report_view";
            this.publisher_last_field_service_report_viewBindingSource.DataSource = this.tMSADataSet;
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(65, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
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
            // 
            // tsReload
            // 
            this.tsReload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsReload.Image = ((System.Drawing.Image)(resources.GetObject("tsReload.Image")));
            this.tsReload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsReload.Name = "tsReload";
            this.tsReload.Size = new System.Drawing.Size(29, 24);
            this.tsReload.Text = "Reload";
            this.tsReload.ToolTipText = "Reload";
            this.tsReload.Click += new System.EventHandler(this.tsReload_Click);
            // 
            // tsPublishers
            // 
            this.tsPublishers.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tsPublishers.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsPublishers.Image = ((System.Drawing.Image)(resources.GetObject("tsPublishers.Image")));
            this.tsPublishers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsPublishers.Name = "tsPublishers";
            this.tsPublishers.Size = new System.Drawing.Size(79, 24);
            this.tsPublishers.Text = "Publishers";
            this.tsPublishers.Click += new System.EventHandler(this.tsPublishers_Click);
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(336, 588);
            this.btnDone.Margin = new System.Windows.Forms.Padding(4);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(100, 28);
            this.btnDone.TabIndex = 24;
            this.btnDone.Text = "done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // picturePictureBox
            // 
            this.picturePictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picturePictureBox.BackgroundImage")));
            this.picturePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picturePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.publisher_last_field_service_report_viewBindingSource, "picture", true));
            this.picturePictureBox.Location = new System.Drawing.Point(481, 250);
            this.picturePictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.picturePictureBox.Name = "picturePictureBox";
            this.picturePictureBox.Size = new System.Drawing.Size(223, 219);
            this.picturePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturePictureBox.TabIndex = 219;
            this.picturePictureBox.TabStop = false;
            // 
            // publisher_groupTextBox
            // 
            this.publisher_groupTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.publisher_last_field_service_report_viewBindingSource, "group", true));
            this.publisher_groupTextBox.Location = new System.Drawing.Point(197, 441);
            this.publisher_groupTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.publisher_groupTextBox.Name = "publisher_groupTextBox";
            this.publisher_groupTextBox.ReadOnly = true;
            this.publisher_groupTextBox.Size = new System.Drawing.Size(237, 22);
            this.publisher_groupTextBox.TabIndex = 238;
            // 
            // publisher_typeTextBox
            // 
            this.publisher_typeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.publisher_last_field_service_report_viewBindingSource, "publisher_type", true));
            this.publisher_typeTextBox.Location = new System.Drawing.Point(199, 364);
            this.publisher_typeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.publisher_typeTextBox.Name = "publisher_typeTextBox";
            this.publisher_typeTextBox.ReadOnly = true;
            this.publisher_typeTextBox.Size = new System.Drawing.Size(237, 22);
            this.publisher_typeTextBox.TabIndex = 236;
            // 
            // publisher_privilegeTextBox
            // 
            this.publisher_privilegeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.publisher_last_field_service_report_viewBindingSource, "privilege", true));
            this.publisher_privilegeTextBox.Location = new System.Drawing.Point(199, 326);
            this.publisher_privilegeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.publisher_privilegeTextBox.Name = "publisher_privilegeTextBox";
            this.publisher_privilegeTextBox.ReadOnly = true;
            this.publisher_privilegeTextBox.Size = new System.Drawing.Size(237, 22);
            this.publisher_privilegeTextBox.TabIndex = 234;
            // 
            // publisher_genderTextBox
            // 
            this.publisher_genderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.publisher_last_field_service_report_viewBindingSource, "gender", true));
            this.publisher_genderTextBox.Location = new System.Drawing.Point(199, 288);
            this.publisher_genderTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.publisher_genderTextBox.Name = "publisher_genderTextBox";
            this.publisher_genderTextBox.ReadOnly = true;
            this.publisher_genderTextBox.Size = new System.Drawing.Size(237, 22);
            this.publisher_genderTextBox.TabIndex = 232;
            // 
            // publisher_nameTextBox
            // 
            this.publisher_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.publisher_last_field_service_report_viewBindingSource, "publisher_name", true));
            this.publisher_nameTextBox.Location = new System.Drawing.Point(199, 250);
            this.publisher_nameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.publisher_nameTextBox.Multiline = true;
            this.publisher_nameTextBox.Name = "publisher_nameTextBox";
            this.publisher_nameTextBox.ReadOnly = true;
            this.publisher_nameTextBox.Size = new System.Drawing.Size(237, 24);
            this.publisher_nameTextBox.TabIndex = 222;
            // 
            // publisher_last_assignment_viewDataGridView
            // 
            this.publisher_last_assignment_viewDataGridView.AllowUserToAddRows = false;
            this.publisher_last_assignment_viewDataGridView.AllowUserToDeleteRows = false;
            this.publisher_last_assignment_viewDataGridView.AllowUserToOrderColumns = true;
            this.publisher_last_assignment_viewDataGridView.AllowUserToResizeColumns = false;
            this.publisher_last_assignment_viewDataGridView.AllowUserToResizeRows = false;
            this.publisher_last_assignment_viewDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.publisher_last_assignment_viewDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.publisher_last_assignment_viewDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.publisher_last_assignment_viewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.publisher_last_assignment_viewDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.publisher_id,
            this.publisher_name,
            this.date,
            this.activeDataGridViewCheckBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.hourtypeDataGridViewTextBoxColumn,
            this.privilegeDataGridViewTextBoxColumn,
            this.publishertypeDataGridViewTextBoxColumn,
            this.groupDataGridViewTextBoxColumn});
            this.publisher_last_assignment_viewDataGridView.DataSource = this.publisher_last_field_service_report_viewBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.publisher_last_assignment_viewDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.publisher_last_assignment_viewDataGridView.Location = new System.Drawing.Point(745, 244);
            this.publisher_last_assignment_viewDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.publisher_last_assignment_viewDataGridView.Name = "publisher_last_assignment_viewDataGridView";
            this.publisher_last_assignment_viewDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.publisher_last_assignment_viewDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.publisher_last_assignment_viewDataGridView.RowHeadersWidth = 51;
            this.publisher_last_assignment_viewDataGridView.ShowCellToolTips = false;
            this.publisher_last_assignment_viewDataGridView.Size = new System.Drawing.Size(335, 410);
            this.publisher_last_assignment_viewDataGridView.TabIndex = 7;
            this.publisher_last_assignment_viewDataGridView.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.publisher_last_assignment_viewDataGridView_CellMouseEnter);
            this.publisher_last_assignment_viewDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.publisher_last_assignment_viewDataGridView_DataError);
            // 
            // publisher_id
            // 
            this.publisher_id.DataPropertyName = "publisher_id";
            this.publisher_id.HeaderText = "publisher_id";
            this.publisher_id.MinimumWidth = 6;
            this.publisher_id.Name = "publisher_id";
            this.publisher_id.ReadOnly = true;
            this.publisher_id.Visible = false;
            this.publisher_id.Width = 85;
            // 
            // publisher_name
            // 
            this.publisher_name.DataPropertyName = "publisher_name";
            this.publisher_name.HeaderText = "Publisher Name";
            this.publisher_name.MinimumWidth = 6;
            this.publisher_name.Name = "publisher_name";
            this.publisher_name.ReadOnly = true;
            this.publisher_name.Width = 125;
            // 
            // date
            // 
            this.date.DataPropertyName = "last_field_service_report_date";
            this.date.HeaderText = "Last Report Date";
            this.date.MinimumWidth = 6;
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Width = 90;
            // 
            // activeDataGridViewCheckBoxColumn
            // 
            this.activeDataGridViewCheckBoxColumn.DataPropertyName = "active";
            this.activeDataGridViewCheckBoxColumn.HeaderText = "active";
            this.activeDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.activeDataGridViewCheckBoxColumn.Name = "activeDataGridViewCheckBoxColumn";
            this.activeDataGridViewCheckBoxColumn.ReadOnly = true;
            this.activeDataGridViewCheckBoxColumn.Visible = false;
            this.activeDataGridViewCheckBoxColumn.Width = 125;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            this.genderDataGridViewTextBoxColumn.Width = 125;
            // 
            // hourtypeDataGridViewTextBoxColumn
            // 
            this.hourtypeDataGridViewTextBoxColumn.DataPropertyName = "hour_type";
            this.hourtypeDataGridViewTextBoxColumn.HeaderText = "Hour Type";
            this.hourtypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hourtypeDataGridViewTextBoxColumn.Name = "hourtypeDataGridViewTextBoxColumn";
            this.hourtypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.hourtypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // privilegeDataGridViewTextBoxColumn
            // 
            this.privilegeDataGridViewTextBoxColumn.DataPropertyName = "privilege";
            this.privilegeDataGridViewTextBoxColumn.HeaderText = "Privilege";
            this.privilegeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.privilegeDataGridViewTextBoxColumn.Name = "privilegeDataGridViewTextBoxColumn";
            this.privilegeDataGridViewTextBoxColumn.ReadOnly = true;
            this.privilegeDataGridViewTextBoxColumn.Width = 125;
            // 
            // publishertypeDataGridViewTextBoxColumn
            // 
            this.publishertypeDataGridViewTextBoxColumn.DataPropertyName = "publisher_type";
            this.publishertypeDataGridViewTextBoxColumn.HeaderText = "Publisher Type";
            this.publishertypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.publishertypeDataGridViewTextBoxColumn.Name = "publishertypeDataGridViewTextBoxColumn";
            this.publishertypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.publishertypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // groupDataGridViewTextBoxColumn
            // 
            this.groupDataGridViewTextBoxColumn.DataPropertyName = "group";
            this.groupDataGridViewTextBoxColumn.HeaderText = "Group";
            this.groupDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.groupDataGridViewTextBoxColumn.Name = "groupDataGridViewTextBoxColumn";
            this.groupDataGridViewTextBoxColumn.ReadOnly = true;
            this.groupDataGridViewTextBoxColumn.Width = 125;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txtSearch);
            this.groupBox2.Location = new System.Drawing.Point(745, 174);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(335, 62);
            this.groupBox2.TabIndex = 245;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filter by publisher name";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(31, 23);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(273, 22);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.DoubleClick += new System.EventHandler(this.txtSearch_DoubleClick);
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.groupBox1.Location = new System.Drawing.Point(48, 43);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1032, 131);
            this.groupBox1.TabIndex = 246;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter by:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 74);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 17);
            this.label7.TabIndex = 355;
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
            this.cmbHourType.Location = new System.Drawing.Point(40, 93);
            this.cmbHourType.Margin = new System.Windows.Forms.Padding(4);
            this.cmbHourType.Name = "cmbHourType";
            this.cmbHourType.Size = new System.Drawing.Size(261, 24);
            this.cmbHourType.TabIndex = 356;
            // 
            // btnClearFilter
            // 
            this.btnClearFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearFilter.BackColor = System.Drawing.SystemColors.Control;
            this.btnClearFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearFilter.Location = new System.Drawing.Point(864, 79);
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
            this.btnFilter.Location = new System.Drawing.Point(864, 35);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(4);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(119, 34);
            this.btnFilter.TabIndex = 344;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // cmbPubliserType
            // 
            this.cmbPubliserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPubliserType.FormattingEnabled = true;
            this.cmbPubliserType.Items.AddRange(new object[] {
            "",
            "Unbaptized Publisher",
            "Baptized Publisher"});
            this.cmbPubliserType.Location = new System.Drawing.Point(37, 45);
            this.cmbPubliserType.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPubliserType.Name = "cmbPubliserType";
            this.cmbPubliserType.Size = new System.Drawing.Size(191, 24);
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
            this.cmbGender.Location = new System.Drawing.Point(664, 45);
            this.cmbGender.Margin = new System.Windows.Forms.Padding(4);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(116, 24);
            this.cmbGender.TabIndex = 173;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 176;
            this.label3.Text = "Publisher type :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(388, 76);
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
            this.cmbGroup.Location = new System.Drawing.Point(393, 45);
            this.cmbGroup.Margin = new System.Windows.Forms.Padding(4);
            this.cmbGroup.Name = "cmbGroup";
            this.cmbGroup.Size = new System.Drawing.Size(124, 24);
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
            this.cmbPrivilege.Location = new System.Drawing.Point(392, 96);
            this.cmbPrivilege.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPrivilege.Name = "cmbPrivilege";
            this.cmbPrivilege.Size = new System.Drawing.Size(169, 24);
            this.cmbPrivilege.TabIndex = 171;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(388, 24);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 174;
            this.label4.Text = "Group :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(660, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 172;
            this.label2.Text = " Gender :";
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.publisher_field_service_reportTableAdapter = null;
            this.tableAdapterManager.publisherTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TMSA.TMSADataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // publisher_last_field_service_report_viewTableAdapter
            // 
            this.publisher_last_field_service_report_viewTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.publisher_last_field_service_report_viewBindingSource, "last_field_service_report_date", true));
            this.textBox1.Location = new System.Drawing.Point(199, 514);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(237, 22);
            this.textBox1.TabIndex = 251;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.publisher_last_field_service_report_viewBindingSource, "hour_type", true));
            this.textBox2.Location = new System.Drawing.Point(197, 402);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(237, 22);
            this.textBox2.TabIndex = 253;
            // 
            // frmChoosePublisher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 701);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(label8);
            this.Controls.Add(label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.publisher_last_assignment_viewBindingNavigator);
            this.Controls.Add(this.publisher_last_assignment_viewDataGridView);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.picturePictureBox);
            this.Controls.Add(this.publisher_groupTextBox);
            this.Controls.Add(publisher_groupLabel);
            this.Controls.Add(this.publisher_typeTextBox);
            this.Controls.Add(publisher_nameLabel);
            this.Controls.Add(publisher_typeLabel);
            this.Controls.Add(this.publisher_nameTextBox);
            this.Controls.Add(this.publisher_privilegeTextBox);
            this.Controls.Add(publisher_privilegeLabel);
            this.Controls.Add(this.publisher_genderTextBox);
            this.Controls.Add(publisher_genderLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmChoosePublisher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choose Publisher";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmChoosePublisher_FormClosed);
            this.Load += new System.EventHandler(this.frmChoosePublisher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.publisher_last_assignment_viewBindingNavigator)).EndInit();
            this.publisher_last_assignment_viewBindingNavigator.ResumeLayout(false);
            this.publisher_last_assignment_viewBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.publisher_last_field_service_report_viewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMSADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publisher_last_assignment_viewDataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private TMSADataSet tMSADataSet;
        private System.Windows.Forms.BindingSource publisher_last_field_service_report_viewBindingSource;
        private TMSADataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator publisher_last_assignment_viewBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.ToolStripButton tsReload;
        private System.Windows.Forms.ToolStripButton tsPublishers;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.PictureBox picturePictureBox;
        private System.Windows.Forms.TextBox publisher_groupTextBox;
        private System.Windows.Forms.TextBox publisher_typeTextBox;
        private System.Windows.Forms.TextBox publisher_privilegeTextBox;
        private System.Windows.Forms.TextBox publisher_genderTextBox;
        private System.Windows.Forms.TextBox publisher_nameTextBox;
        private System.Windows.Forms.DataGridView publisher_last_assignment_viewDataGridView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClearFilter;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.ComboBox cmbPubliserType;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbGroup;
        private System.Windows.Forms.ComboBox cmbPrivilege;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
        private TMSADataSetTableAdapters.publisher_last_field_service_report_viewTableAdapter publisher_last_field_service_report_viewTableAdapter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbHourType;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisher_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisher_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activeDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hourtypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn privilegeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publishertypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupDataGridViewTextBoxColumn;
    }
}