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
    public partial class frmMessageBoxForm : Form
    {
        public frmMessageBoxForm(string message)
        {
            InitializeComponent();
            lblMessage.Text = message;
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
        private void MessageBoxForm_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle, Color.DarkOrange, ButtonBorderStyle.Solid);
        }

        private void Label1_MouseDown(object sender, MouseEventArgs e)
        {
            Dragging = true;
            StartPoint = new Point(e.X, e.Y);
        }

        private void Label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.StartPoint.X, p.Y - this.StartPoint.Y);
            }
        }

        private void Label1_MouseUp(object sender, MouseEventArgs e)
        {
            Dragging = false;
        }
        #endregion

        public bool yes
        {
            get { return btnYes.Visible; }
            set { btnYes.Visible = value; }
        }
        public bool no
        {
            get { return btnNo.Visible; }
            set { btnNo.Visible = value; }
        }
        public bool cancel
        {
            get { return btnCancel.Visible; }
            set { btnCancel.Visible = value; }
        }

        public bool ok
        {
            get { return btnOK.Visible; }
            set { btnOK.Visible = value; }
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MessageBoxForm_Load(object sender, EventArgs e)
        {

        }
    }
}
