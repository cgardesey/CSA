namespace TMSA
{
    partial class frmPublisherCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPublisherCard));
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnSaveLocBrowse = new System.Windows.Forms.Button();
            this.saveLocTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tMSADataSet = new TMSA.TMSADataSet();
            this.getServiceYearsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getServiceYearsTableAdapter = new TMSA.TMSADataSetTableAdapters.GetServiceYearsTableAdapter();
            this.tableAdapterManager = new TMSA.TMSADataSetTableAdapters.TableAdapterManager();
            this.service_yearComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSampleCardBrowse = new System.Windows.Forms.Button();
            this.sampleCardTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnGenerateSummaries = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tMSADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getServiceYearsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBackup
            // 
            this.btnBackup.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.btnBackup, "btnBackup");
            this.btnBackup.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.UseVisualStyleBackColor = false;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnSaveLocBrowse
            // 
            this.btnSaveLocBrowse.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.btnSaveLocBrowse, "btnSaveLocBrowse");
            this.btnSaveLocBrowse.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSaveLocBrowse.Name = "btnSaveLocBrowse";
            this.btnSaveLocBrowse.UseVisualStyleBackColor = false;
            this.btnSaveLocBrowse.Click += new System.EventHandler(this.btnBackupLocBrowse_Click);
            // 
            // saveLocTextBox
            // 
            resources.ApplyResources(this.saveLocTextBox, "saveLocTextBox");
            this.saveLocTextBox.Name = "saveLocTextBox";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Name = "label4";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Name = "label1";
            // 
            // tMSADataSet
            // 
            this.tMSADataSet.DataSetName = "TMSADataSet";
            this.tMSADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getServiceYearsBindingSource
            // 
            this.getServiceYearsBindingSource.DataMember = "GetServiceYears";
            this.getServiceYearsBindingSource.DataSource = this.tMSADataSet;
            // 
            // getServiceYearsTableAdapter
            // 
            this.getServiceYearsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.publisher_field_service_reportTableAdapter = null;
            this.tableAdapterManager.publisherTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TMSA.TMSADataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // service_yearComboBox
            // 
            this.service_yearComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.getServiceYearsBindingSource, "service_year", true));
            this.service_yearComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.getServiceYearsBindingSource, "service_year", true));
            this.service_yearComboBox.DataSource = this.getServiceYearsBindingSource;
            this.service_yearComboBox.DisplayMember = "service_year";
            this.service_yearComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.service_yearComboBox.FormattingEnabled = true;
            resources.ApplyResources(this.service_yearComboBox, "service_yearComboBox");
            this.service_yearComboBox.Name = "service_yearComboBox";
            this.service_yearComboBox.ValueMember = "service_year";
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Name = "label2";
            // 
            // btnSampleCardBrowse
            // 
            this.btnSampleCardBrowse.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.btnSampleCardBrowse, "btnSampleCardBrowse");
            this.btnSampleCardBrowse.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSampleCardBrowse.Name = "btnSampleCardBrowse";
            this.btnSampleCardBrowse.UseVisualStyleBackColor = false;
            this.btnSampleCardBrowse.Click += new System.EventHandler(this.btnSampleCardBrowse_Click);
            // 
            // sampleCardTextBox
            // 
            resources.ApplyResources(this.sampleCardTextBox, "sampleCardTextBox");
            this.sampleCardTextBox.Name = "sampleCardTextBox";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnGenerateSummaries
            // 
            this.btnGenerateSummaries.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.btnGenerateSummaries, "btnGenerateSummaries");
            this.btnGenerateSummaries.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGenerateSummaries.Name = "btnGenerateSummaries";
            this.btnGenerateSummaries.UseVisualStyleBackColor = false;
            this.btnGenerateSummaries.Click += new System.EventHandler(this.btnGenerateSummaries_Click);
            // 
            // frmPublisherCard
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.btnGenerateSummaries);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSampleCardBrowse);
            this.Controls.Add(this.sampleCardTextBox);
            this.Controls.Add(this.service_yearComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSaveLocBrowse);
            this.Controls.Add(this.saveLocTextBox);
            this.Controls.Add(this.btnBackup);
            this.Controls.Add(this.label4);
            this.MaximizeBox = false;
            this.Name = "frmPublisherCard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPublisherCard_FormClosed);
            this.Load += new System.EventHandler(this.frmBackupAndRestore_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.BackupAndRestore_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.tMSADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getServiceYearsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Button btnSaveLocBrowse;
        private System.Windows.Forms.TextBox saveLocTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private TMSADataSet tMSADataSet;
        private System.Windows.Forms.BindingSource getServiceYearsBindingSource;
        private TMSADataSetTableAdapters.GetServiceYearsTableAdapter getServiceYearsTableAdapter;
        private TMSADataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox service_yearComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSampleCardBrowse;
        private System.Windows.Forms.TextBox sampleCardTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnGenerateSummaries;
    }
}