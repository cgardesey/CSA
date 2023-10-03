namespace TMSA
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnFSrecordsImport = new System.Windows.Forms.Button();
            this.btnFSreport = new System.Windows.Forms.Button();
            this.btnPublishers = new System.Windows.Forms.Button();
            this.btnFSrecord = new System.Windows.Forms.Button();
            this.lblCongName = new System.Windows.Forms.Label();
            this.btnApplicationSettings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(198, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 171;
            this.label1.Text = "CSA";
            this.toolTip1.SetToolTip(this.label1, "Congregation Secretary Assistant");
            // 
            // btnFSrecordsImport
            // 
            this.btnFSrecordsImport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFSrecordsImport.BackColor = System.Drawing.Color.LightGray;
            this.btnFSrecordsImport.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.btnFSrecordsImport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnFSrecordsImport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnFSrecordsImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFSrecordsImport.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFSrecordsImport.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFSrecordsImport.Image = ((System.Drawing.Image)(resources.GetObject("btnFSrecordsImport.Image")));
            this.btnFSrecordsImport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFSrecordsImport.Location = new System.Drawing.Point(27, 296);
            this.btnFSrecordsImport.Margin = new System.Windows.Forms.Padding(4);
            this.btnFSrecordsImport.Name = "btnFSrecordsImport";
            this.btnFSrecordsImport.Size = new System.Drawing.Size(389, 68);
            this.btnFSrecordsImport.TabIndex = 175;
            this.btnFSrecordsImport.Text = "Field Service Records Import";
            this.toolTip1.SetToolTip(this.btnFSrecordsImport, "Bulk import field service records from excel sheet");
            this.btnFSrecordsImport.UseVisualStyleBackColor = false;
            this.btnFSrecordsImport.Click += new System.EventHandler(this.btnFSRimport_Click);
            this.btnFSrecordsImport.MouseEnter += new System.EventHandler(this.btnFSrecordsImport_MouseEnter_1);
            this.btnFSrecordsImport.MouseLeave += new System.EventHandler(this.btnFSrecordsImport_MouseLeave);
            // 
            // btnFSreport
            // 
            this.btnFSreport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFSreport.BackColor = System.Drawing.Color.LightGray;
            this.btnFSreport.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.btnFSreport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnFSreport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnFSreport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFSreport.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFSreport.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFSreport.Image = ((System.Drawing.Image)(resources.GetObject("btnFSreport.Image")));
            this.btnFSreport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFSreport.Location = new System.Drawing.Point(30, 387);
            this.btnFSreport.Margin = new System.Windows.Forms.Padding(4);
            this.btnFSreport.Name = "btnFSreport";
            this.btnFSreport.Size = new System.Drawing.Size(389, 68);
            this.btnFSreport.TabIndex = 174;
            this.btnFSreport.Text = "Field Service Records Report";
            this.toolTip1.SetToolTip(this.btnFSreport, "View printable report of field service records");
            this.btnFSreport.UseVisualStyleBackColor = false;
            this.btnFSreport.Click += new System.EventHandler(this.btnFSreport_Click);
            this.btnFSreport.MouseEnter += new System.EventHandler(this.btnFSreport_MouseEnter);
            this.btnFSreport.MouseLeave += new System.EventHandler(this.btnFSreport_MouseLeave);
            // 
            // btnPublishers
            // 
            this.btnPublishers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPublishers.BackColor = System.Drawing.Color.LightGray;
            this.btnPublishers.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.btnPublishers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnPublishers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnPublishers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPublishers.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPublishers.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPublishers.Image = ((System.Drawing.Image)(resources.GetObject("btnPublishers.Image")));
            this.btnPublishers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPublishers.Location = new System.Drawing.Point(27, 112);
            this.btnPublishers.Margin = new System.Windows.Forms.Padding(4);
            this.btnPublishers.Name = "btnPublishers";
            this.btnPublishers.Size = new System.Drawing.Size(389, 68);
            this.btnPublishers.TabIndex = 163;
            this.btnPublishers.Text = "Publishers";
            this.toolTip1.SetToolTip(this.btnPublishers, "View or insert publisher informan");
            this.btnPublishers.UseVisualStyleBackColor = false;
            this.btnPublishers.Click += new System.EventHandler(this.btnPublishers_Click);
            this.btnPublishers.MouseEnter += new System.EventHandler(this.btnPublishers_MouseEnter);
            this.btnPublishers.MouseLeave += new System.EventHandler(this.btnPublishers_MouseLeave);
            // 
            // btnFSrecord
            // 
            this.btnFSrecord.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFSrecord.BackColor = System.Drawing.Color.LightGray;
            this.btnFSrecord.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.btnFSrecord.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnFSrecord.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnFSrecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFSrecord.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFSrecord.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFSrecord.Image = ((System.Drawing.Image)(resources.GetObject("btnFSrecord.Image")));
            this.btnFSrecord.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFSrecord.Location = new System.Drawing.Point(27, 204);
            this.btnFSrecord.Margin = new System.Windows.Forms.Padding(4);
            this.btnFSrecord.Name = "btnFSrecord";
            this.btnFSrecord.Size = new System.Drawing.Size(389, 68);
            this.btnFSrecord.TabIndex = 166;
            this.btnFSrecord.Text = "Field Service Records";
            this.toolTip1.SetToolTip(this.btnFSrecord, "View or insert filed service records");
            this.btnFSrecord.UseVisualStyleBackColor = false;
            this.btnFSrecord.Click += new System.EventHandler(this.btnFSR_Click);
            this.btnFSrecord.MouseEnter += new System.EventHandler(this.btnFSrecord_MouseEnter);
            this.btnFSrecord.MouseLeave += new System.EventHandler(this.btnFSrecord_MouseLeave);
            // 
            // lblCongName
            // 
            this.lblCongName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCongName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCongName.Location = new System.Drawing.Point(27, 49);
            this.lblCongName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCongName.Name = "lblCongName";
            this.lblCongName.Size = new System.Drawing.Size(390, 29);
            this.lblCongName.TabIndex = 176;
            this.lblCongName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnApplicationSettings
            // 
            this.btnApplicationSettings.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnApplicationSettings.BackColor = System.Drawing.Color.LightGray;
            this.btnApplicationSettings.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.btnApplicationSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnApplicationSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnApplicationSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApplicationSettings.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApplicationSettings.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnApplicationSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnApplicationSettings.Image")));
            this.btnApplicationSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApplicationSettings.Location = new System.Drawing.Point(33, 481);
            this.btnApplicationSettings.Margin = new System.Windows.Forms.Padding(4);
            this.btnApplicationSettings.Name = "btnApplicationSettings";
            this.btnApplicationSettings.Size = new System.Drawing.Size(389, 68);
            this.btnApplicationSettings.TabIndex = 177;
            this.btnApplicationSettings.Text = "Application Settings";
            this.toolTip1.SetToolTip(this.btnApplicationSettings, "Set congregation name and database connection string");
            this.btnApplicationSettings.UseVisualStyleBackColor = false;
            this.btnApplicationSettings.Click += new System.EventHandler(this.btnApplicationSettings_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(445, 579);
            this.Controls.Add(this.btnApplicationSettings);
            this.Controls.Add(this.lblCongName);
            this.Controls.Add(this.btnFSrecordsImport);
            this.Controls.Add(this.btnFSreport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPublishers);
            this.Controls.Add(this.btnFSrecord);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CSA";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        internal System.Windows.Forms.Button btnFSrecord;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Button btnFSreport;
        internal System.Windows.Forms.Button btnFSrecordsImport;
        internal System.Windows.Forms.Button btnPublishers;
        private System.Windows.Forms.Label lblCongName;
        internal System.Windows.Forms.Button btnApplicationSettings;
    }
}