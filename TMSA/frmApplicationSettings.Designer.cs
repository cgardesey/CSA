
namespace TMSA
{
    partial class frmApplicationSettings
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
            this.btnOk = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCongName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbConString = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.SystemColors.Control;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOk.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnOk.Location = new System.Drawing.Point(518, 193);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(54, 28);
            this.btnOk.TabIndex = 188;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 10F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(51, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 75);
            this.label2.TabIndex = 187;
            this.label2.Text = "Congregation name:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbCongName
            // 
            this.tbCongName.Location = new System.Drawing.Point(189, 78);
            this.tbCongName.Margin = new System.Windows.Forms.Padding(4);
            this.tbCongName.Name = "tbCongName";
            this.tbCongName.Size = new System.Drawing.Size(383, 22);
            this.tbCongName.TabIndex = 186;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 10F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(51, 125);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 103);
            this.label1.TabIndex = 185;
            this.label1.Text = "Db connection string:";
            // 
            // tbConString
            // 
            this.tbConString.Location = new System.Drawing.Point(189, 136);
            this.tbConString.Margin = new System.Windows.Forms.Padding(4);
            this.tbConString.Name = "tbConString";
            this.tbConString.Size = new System.Drawing.Size(383, 22);
            this.tbConString.TabIndex = 184;
            // 
            // frmApplicationSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 266);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbCongName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbConString);
            this.Name = "frmApplicationSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Application Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmApplicationSettings_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmApplicationSettings_FormClosed);
            this.Load += new System.EventHandler(this.frmApplicationSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCongName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbConString;
    }
}