using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Library_Management_System.UI
{
    public partial class FieldBoxBar : UserControl
    {
        public event Action Save;
        public event Action Cancel;
        public FieldBoxBar()
        {
            InitializeComponent();
        }
        //Text = category.CategoryName, EditMode = true, LabelText = fa_IR.CategoryName 
        public void AddFieldBox(FieldBox fieldBox)
        {
            flpFieldBoxBar.Controls.Add(fieldBox);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Save!=null)
                Save();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (Cancel!=null)
                Cancel();
        }
    }
}
