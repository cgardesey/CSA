using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TMSA
{
    public class SimpleDirtyTracker
    {
        private Form _frmTracked;
        private bool _isDirty;
        TextBox id;

        public SimpleDirtyTracker(Form frm, TextBox id)
        {
            this.id = id;
            _frmTracked = frm;
            AssignHandlersForControlCollection(frm.Controls);            
        }

        public bool IsDirty
        {
            get { return _isDirty; }
            set { _isDirty = value; }
        }

        public void SetAsDirty()
        {
            _isDirty = true;
        }

        public void SetAsClean()
        {
            _isDirty = false;
        }

        // event handlers
        private void SimpleDirtyTracker_TextChanged(object sender, EventArgs e)
        {
            _isDirty = true;
        }

        private void SimpleDirtyTracker_CheckedChanged(object sender, EventArgs e)
        {
            _isDirty = true;
        }

        private void SimpleDirtyTracker_ValueChanged(object sender, EventArgs e)
        {
            _isDirty = true;
        }

        // recursive routine to inspect each control and assign handlers accordingly
        public void AssignHandlersForControlCollection(Control.ControlCollection coll)
        {
            foreach (Control c in coll)
            {
                if (c is TextBox && c.Name != id.Name)
                    (c as TextBox).TextChanged += new EventHandler(SimpleDirtyTracker_TextChanged);

                if (c is CheckBox)
                    (c as CheckBox).CheckedChanged += new EventHandler(SimpleDirtyTracker_CheckedChanged);

                if (c is ComboBox)
                    (c as ComboBox).TextChanged += new EventHandler(SimpleDirtyTracker_TextChanged);

                if (c is DateTimePicker)
                    (c as DateTimePicker).ValueChanged += new EventHandler(SimpleDirtyTracker_ValueChanged);

                // recurively apply to inner collections
                if (c.HasChildren)
                    AssignHandlersForControlCollection(c.Controls);
            }
        }

        public void RemoveHandlersForControlCollection(Control.ControlCollection coll)
        {
            foreach (Control c in coll)
            {
                if (c is TextBox && c.Name != id.Name)


                    if (c is CheckBox)
                        (c as CheckBox).CheckedChanged -= new EventHandler(SimpleDirtyTracker_CheckedChanged);

                if (c is ComboBox)
                    (c as ComboBox).TextChanged -= new EventHandler(SimpleDirtyTracker_TextChanged);

                if (c is DateTimePicker)
                    (c as DateTimePicker).ValueChanged -= new EventHandler(SimpleDirtyTracker_ValueChanged);

                // recurively apply to inner collections
                if (c.HasChildren)
                    RemoveHandlersForControlCollection(c.Controls);
            }
        }
    }
}
