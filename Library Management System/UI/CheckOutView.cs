using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Library_Management_System.Logic;
using Library_Management_System.Languages;
namespace Library_Management_System.UI
{
    public partial class CheckOutView : UserControl
    {
        LibraryMangementSystem LMS;
        public CheckOutView()
        {
            InitializeComponent();
            LMS = LibraryMangementSystem.CreateLibraryMangementSystem();
            cbBorrowers.DataSource = LMS.Borrowers;
            lblBorrower.Text = fa_IR.Borrower;
            
        }

        private void cbBorrowers_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitializeCheckOutsDataGridView();
            dgvCheckOuts.DataSource = LMS.FilterCheckOuts(cbBorrowers.SelectedValue as Borrower);
        }
        private void InitializeCheckOutsDataGridView()
        {

            dgvCheckOuts.AutoGenerateColumns = false;

            if (dgvCheckOuts.Columns.Count == 0)
            {
                dgvCheckOuts.Columns.Add("Status", fa_IR.BorrowStatus);
                dgvCheckOuts.Columns.Add("BorrowDate", fa_IR.BorrowDate);
                dgvCheckOuts.Columns.Add("DueDate", fa_IR.DueDate);
                dgvCheckOuts.Columns.Add("ReturnDate", fa_IR.ReturnDate);


                dgvCheckOuts.Columns["Status"].DataPropertyName = "Status";
                dgvCheckOuts.Columns["BorrowDate"].DataPropertyName = "BorrowDate";
                dgvCheckOuts.Columns["DueDate"].DataPropertyName = "DueDate";
                dgvCheckOuts.Columns["ReturnDate"].DataPropertyName = "ReturnDate";

            }
        }
        private void InitializeBooksDataGridView()
        {
            dgvBooks.AutoGenerateColumns = false;
            if (dgvBooks.Columns.Count == 0)
            {
                dgvBooks.Columns.Add("Title", fa_IR.BookTitle);
                dgvBooks.Columns.Add("ISBN", fa_IR.ISBN);
                dgvBooks.Columns.Add("Author", fa_IR.ISBN);



                dgvBooks.Columns["Title"].DataPropertyName = "Title";
                dgvBooks.Columns["ISBN"].DataPropertyName = "ISBN";
                dgvBooks.Columns["Author"].DataPropertyName = "Author";

            }
        }

        private void dgvCheckOuts_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            InitializeBooksDataGridView();
            CheckOut checkOut=dgvCheckOuts.Rows[e.RowIndex].DataBoundItem as CheckOut;
            dgvBooks.DataSource = checkOut.Books;
        }

        private void dgvCheckOuts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CheckOut checkOut = dgvCheckOuts.Rows[e.RowIndex].DataBoundItem as CheckOut;
            if (checkOut.Status != CheckOutStatus.Returned)
            {
                DialogResult result = MessageBox.Show(fa_IR.ConfirmReturn, fa_IR.Notification, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    LMS.ReturnBooks(checkOut, DateTime.UtcNow);
                }
            }
            else MessageBox.Show(fa_IR.AlreadyReturned);
        }

        private void dgvCheckOuts_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
            if (e.ColumnIndex == 0) // Check for the column you want
            {
                switch ((CheckOutStatus)e.Value)
                {
                    case CheckOutStatus.Returned:
                        e.Value = fa_IR.ReturedStatus;
                        break;
                    case CheckOutStatus.CheckedOut:
                        e.Value=fa_IR.CheckedOutStatus;
                        break;
                    case CheckOutStatus.Overdue:
                        e.Value = fa_IR.OverdueStatus;
                        break;
                }
                e.FormattingApplied = true;
            }
    
        }
    }
}
