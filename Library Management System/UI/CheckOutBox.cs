using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using Library_Management_System.Languages;
using Library_Management_System.Logic;
namespace Library_Management_System
{
    public partial class CheckOutBox : UserControl
    {
        private Borrower _borrower;
        LibraryMangementSystem LMS;
        public CheckOutBox()
        {
            InitializeComponent();
            LMS = LibraryMangementSystem.CreateLibraryMangementSystem();

            lblBorrower.Text = fa_IR.Borrower;
            lblDueDate.Text = fa_IR.DueDate;
            btnCheckOut.Text = fa_IR.CheckOut;

            lblBirthDate.Text = fa_IR.BirthDate;
            lblFIrstName.Text = fa_IR.FirstName;
            lblLastName.Text = fa_IR.LastName;
            lblUserId.Text = fa_IR.UserId;
        }


        public ListBox SelectedBooks
        {
            get
            {
                return lstSelectedBooks;
            }
        }
        public ComboBox Borrowers
        {
            get
            {
                return cbBorrowers;
            }
        }
        public DateTimePicker DueDate
        {
            get
            {
                return dtpDueDate;
            }
        }
        public Button CheckOutButton
        {
            get
            {
                return btnCheckOut;
            }
        }
        public Button AddBorrowerButton
        {
            get
            {
                return btnAddBorrower;
            }
        }
        public Borrower Borrower
        {
            get
            {
                if (_borrower == null)
                    _borrower = cbBorrowers.SelectedValue as Borrower;
                return _borrower;
            }
        }
        public Button RegistrationButton
        {
            get
            {
                return btnRegister;
            }
        }
        private void CheckOutBox_Load(object sender, EventArgs e)
        {

        }

        private void btnAddBorrower_Click(object sender, EventArgs e)
        {
            flpCheckOut.Visible = false;
            flpAddOrEditBorrower.Visible = true;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            LMS.AddNewBorrower(int.Parse(txtUserId.Text),txtFirstName.Text,txtLastName.Text,dtpBirthDate.Value);
            cbBorrowers.DataSource = LMS.Borrowers;

            flpCheckOut.Visible = true;
            flpAddOrEditBorrower.Visible = false;

        }

        private void flpCheckOutBox_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEditBorrower_Click(object sender, EventArgs e)
        {
            flpAddOrEditBorrower.Visible = true;
            btnSubmitEditBorrower.Visible = true;
            flpCheckOut.Visible = false;
            btnRegister.Hide();

            _borrower = cbBorrowers.SelectedValue as Borrower;
            txtFirstName.Text = _borrower.FirstName;
            txtLastName.Text = _borrower.LastName;
            txtUserId.Text = _borrower.UserId.ToString();
            dtpBirthDate.Value = _borrower.BirthDate;

        }
        public Button EditButton
        {

            get
            {
                return btnSubmitEditBorrower;
            }

        }
        public Button DeleteButton
        {

            get
            {
                return btnDeleteBorrower;
            }

        }

        private void btnSubmitEditBorrower_Click(object sender, EventArgs e)
        {
            _borrower.FirstName = txtFirstName.Text;
            _borrower.LastName = txtLastName.Text;
            _borrower.UserId = int.Parse(txtUserId.Text);
            _borrower.BirthDate = dtpBirthDate.Value;


            btnSubmitEditBorrower.Hide();
            btnRegister.Show();
            flpCheckOut.Show();
            flpAddOrEditBorrower.Hide();
        }

        private void btnDeleteBorrower_Click(object sender, EventArgs e)
        {
            _borrower = cbBorrowers.SelectedValue as Borrower;
        }

        private void flpCheckOut_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
