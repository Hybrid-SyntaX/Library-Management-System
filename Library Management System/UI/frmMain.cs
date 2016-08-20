using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using DatabaseFactory;
using Library_Management_System.Logic;
using System.Globalization;
using System.Resources;
using System.Threading;
using System.Reflection;
using Library_Management_System.Languages;
namespace Library_Management_System
{

    public partial class frmMain : Form
    {
        LibraryMangementSystem LMS;
        CheckOutBox checkOutBox;
        BookPanel bookPanel;
        UI.CheckOutView checkOutView;
        public frmMain()
        {
            
            LMS = LibraryMangementSystem.CreateLibraryMangementSystem();
            LMS.DataSourceChanged += new LMSEventHandler(LMS_DataSourceChanged);

            InitializeComponent();
            InitializeBooksDataGridView();

            checkOutBox = new CheckOutBox();
            splitLMS.Panel2.Controls.Add(checkOutBox);
            bookPanel = new BookPanel();
            bookPanel.Name = "bookPanel";
            checkOutBox.CheckOutButton.Click += new EventHandler(CheckOutButton_Click);
            checkOutBox.EditButton.Click += new EventHandler(EditButton_Click);
            checkOutBox.Borrowers.DataSource = LMS.Borrowers;
            checkOutBox.DeleteButton.Click += new EventHandler(DeleteButton_Click);

            if (!splitLMS.Panel2.Controls.ContainsKey("bookPanel"))
                splitLMS.Panel2.Controls.Add(bookPanel);

            checkOutBox.Hide();
            
            checkOutBox.Name = "checkOutBox";
            checkOutView = new UI.CheckOutView();

            splitLMS.Panel2.Controls.Add(checkOutView);
            checkOutView.Hide();
            btnShowCheckout.Text = fa_IR.CheckOuts;
            this.Text = fa_IR.LMS;
        }
        void LMS_DataSourceChanged(object sender, LMSEventArgs e)
        {
            if (e.EntityName == "Book")
                ShowBooksDataGridView();
            if (e.EntityName == "Category")
                cbCategory.DataSource = LMS.Categories;
            if (e.EntityName == "Author")
                cbAuthor.DataSource = LMS.Authors;
            if (e.EntityName == "Publisher")
                cbPublisher.DataSource = LMS.Publishers;
        }

        void DeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Delete blah", "Delete", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (checkOutBox.Borrower != null)
                {
                    LMS.DeleteBorrower(checkOutBox.Borrower);
                    checkOutBox.Borrowers.DataSource = LMS.Borrowers;
                    checkOutBox.Borrowers.Refresh();
                }
            }
        }

        void EditButton_Click(object sender, EventArgs e)
        {
            if (checkOutBox.Borrower != null)
            {
                LMS.EditBorrower(checkOutBox.Borrower);
                checkOutBox.Borrowers.DataSource = LMS.Borrowers;
                checkOutBox.Borrowers.Refresh();
            }
        }





        void CheckOutButton_Click(object sender, EventArgs e)
        {
            Borrower borrower = checkOutBox.Borrowers.SelectedValue as Borrower;
            List<Book> selectedBooks = new List<Book>();
            foreach (Book book in checkOutBox.SelectedBooks.Items)
            {
                selectedBooks.Add(book);
            }
            DateTime dueDate = checkOutBox.DueDate.Value;
            LMS.SubmitCheckOut(borrower, selectedBooks, dueDate);
        }
        void AttrachCombobox(IList list, FlowLayoutPanel flp, string LabelText, string DisplayMember, string ValueMember, Action<object, EventArgs> comboChangedEvent)
        {
            ComboBox comboBox = new ComboBox();
            comboBox.DisplayMember = DisplayMember;
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox.ValueMember = ValueMember;
            comboBox.RightToLeft = System.Windows.Forms.RightToLeft.Inherit;
            comboBox.DataSource = list;

            comboBox.SelectedValueChanged += new EventHandler(comboChangedEvent);

            Label lbl = new Label();
            lbl.Text = LabelText;
            lbl.TextAlign = ContentAlignment.MiddleCenter;
            lbl.AutoSize = true;
            lbl.Margin = new System.Windows.Forms.Padding(8);


            flp.Controls.Add(lbl);
            flp.Controls.Add(comboBox);
        }

        private void AutoConfigureDataGridView(DataGridView dgv, Type t)
        {
            List<PropertyInfo> properties = new List<PropertyInfo>(t.GetProperties());

            foreach (PropertyInfo p in properties)
            {
                DataGridViewCell cell = null;
                DataGridViewColumn column = null;
                if (p is IList)
                {
                    cell = new DataGridViewComboBoxCell();
                    column = new DataGridViewComboBoxColumn();
                }
                else
                {
                    cell = new DataGridViewTextBoxCell();
                    column = new DataGridViewColumn(cell);

                }

                column.HeaderText = p.Name;
                column.DataPropertyName = p.Name;
                dgv.Columns.Add(column);
            }
            dgv.AutoGenerateColumns = false;

        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            chkAllAuthors.Text = chkAllCategories.Text = chkAllPublishers.Text = fa_IR.All;

            lblAuthor.Text = fa_IR.Author;
            lblPublisher.Text = fa_IR.Publisher;
            lblCategory.Text = fa_IR.Category;
            lblSearch.Text = fa_IR.Search;

            cbAuthor.DataSource = LMS.Authors;
            cbPublisher.DataSource = LMS.Publishers;
            cbCategory.DataSource = LMS.Categories;



            ShowBooksDataGridView();
        }
        void ShowBooksDataGridView()
        {

            dgvBooks.DataSource = LMS.FilterBooks(
                (chkAllCategories.Checked) ? null : (Category)cbCategory.SelectedValue,
                (chkAllPublishers.Checked) ? null : (Publisher)cbPublisher.SelectedValue,
                (chkAllAuthors.Checked) ? null : (Author)cbAuthor.SelectedValue,
                                                    txtSearch.Text,
                                                    SearchOperand.AND).ToList();

        }
        private void InitializeBooksDataGridView()
        {

            dgvBooks.AutoGenerateColumns = false;

            if (dgvBooks.Columns.Count == 0)
            {
                dgvBooks.Columns.Add("Title", fa_IR.BookTitle);
                dgvBooks.Columns.Add("NID", fa_IR.NID);
                dgvBooks.Columns.Add("DCCID", fa_IR.DCCID);
                dgvBooks.Columns.Add("LCID", fa_IR.LCID);
                dgvBooks.Columns.Add("ISBN", fa_IR.ISBN);
                dgvBooks.Columns.Add("Category", fa_IR.Category);
                dgvBooks.Columns.Add("Publisher", fa_IR.Publisher);
                dgvBooks.Columns.Add("Author", fa_IR.Author);
                dgvBooks.Columns.Add("Abstract", fa_IR.BookAbstract);
                dgvBooks.Columns.Add("NumberofPages", fa_IR.NumberOfPages);
                dgvBooks.Columns.Add("PublishYear", fa_IR.PublishYear);


                dgvBooks.Columns["Title"].DataPropertyName = "Title";
                dgvBooks.Columns["NID"].DataPropertyName = "NID";
                dgvBooks.Columns["DCCID"].DataPropertyName = "DCCID";
                dgvBooks.Columns["LCID"].DataPropertyName = "LCID";
                dgvBooks.Columns["ISBN"].DataPropertyName = "ISBN";
                dgvBooks.Columns["Category"].DataPropertyName = "Category";
                dgvBooks.Columns["Publisher"].DataPropertyName = "Publisher";
                dgvBooks.Columns["Author"].DataPropertyName = "Author";
                dgvBooks.Columns["Abstract"].DataPropertyName = "Abstract";
                dgvBooks.Columns["NumberofPages"].DataPropertyName = "NumberofPages";
                dgvBooks.Columns["PublishYear"].DataPropertyName = "PublishYear";
            }
        }

        private void dgvBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbCategory_SelectedValueChanged(object sender, EventArgs e)
        {
            this.ShowBooksDataGridView();
        }

        private void cbPublisher_SelectedValueChanged(object sender, EventArgs e)
        {
            this.ShowBooksDataGridView();
        }

        private void cbAuthor_SelectedValueChanged(object sender, EventArgs e)
        {
            this.ShowBooksDataGridView();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            this.ShowBooksDataGridView();
        }

        private void chkAllAuthors_CheckedChanged(object sender, EventArgs e)
        {
            cbAuthor.Enabled = !(sender as CheckBox).Checked;
            ShowBooksDataGridView();
        }


        private void chkAllCategories_CheckedChanged(object sender, EventArgs e)
        {
            cbCategory.Enabled = !(sender as CheckBox).Checked;
            ShowBooksDataGridView();


        }
 

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void cbPublisher_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chkAllPublishers_CheckedChanged(object sender, EventArgs e)
        {
            cbPublisher.Enabled = !(sender as CheckBox).Checked;
            ShowBooksDataGridView();
        }

        private void dgvBooks_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnShowCheckout.Checked = false;
            bookPanel.Hide();
            checkOutView.Hide();
            checkOutBox.Show();
            DataGridView dgv = sender as DataGridView;
            Book book = dgv.Rows[e.RowIndex].DataBoundItem as Book;

            if (!checkOutBox.SelectedBooks.Items.Contains(book))
                checkOutBox.SelectedBooks.Items.Add(book);
        }


        private void mainToolbar_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dgvBooks_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            btnShowCheckout.Checked = false;
            checkOutBox.Hide();
            checkOutView.Hide();
            bookPanel.Show();
            if (dgvBooks.Rows[e.RowIndex].DataBoundItem != null)
            {
                bookPanel.CurrentBook = dgvBooks.Rows[e.RowIndex].DataBoundItem as Book;
                bookPanel.Rebind();
            }

            //Show themhere

        }

        private void splitLMS_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void ToggleFiltersShowHide(bool show)
        {
            if (show)
            {
                flpFilter.Height = 26;
                foreach (Control control in flpFilter.Controls) control.Show();
            }
            else
            {
                flpFilter.Height = 36;
                foreach (Control control in flpFilter.Controls) control.Hide();
            }
        }
        private void processControlCombo(object sender, ComboBox combo, FlowLayoutPanel flp)
        {

            ComboBox comboControl = sender as ComboBox;

            switch (comboControl.SelectedItem.ToString())
            {
                case "+":

                    ToggleFiltersShowHide(false);
                    flpFilter.Controls.Add(flp);
                    flpFilter.Height += 10;

                    break;
                case "E":
                    break;
                case "X":
                    break;
            }
        }
        private void comboCategoryControls_SelectedIndexChanged(object sender, EventArgs e)
        {

            UI.FieldBoxBar fieledBoxBar = new UI.FieldBoxBar() { Width = this.Width };

            Category category = cbCategory.SelectedValue as Category;
            FieldBox fbCategoryName = new FieldBox() { EditMode = true, LabelText = fa_IR.CategoryName };
            FieldBox fbCategoryDescription = new FieldBox() { EditMode = true, LabelText = fa_IR.Description };

            fieledBoxBar.AddFieldBox(fbCategoryName);
            fieledBoxBar.AddFieldBox(fbCategoryDescription);

            if ((sender as ComboBox).SelectedItem as string == "+")
            {
                fieledBoxBar.Save += new Action(delegate()
                {
                    LMS.AddNewCategory(fbCategoryName.ToValueString(), fbCategoryDescription.ToValueString());
                    ToggleFiltersShowHide(true);
                });

                ToggleFiltersShowHide(false);
                flpFilter.Controls.Add(fieledBoxBar);
            }
            if ((sender as ComboBox).SelectedItem as string == "E")
            {
                fbCategoryName.Text = category.CategoryName;
                fbCategoryDescription.Text = category.Description;
                fieledBoxBar.Save += new Action(delegate()
                    {
                        LMS.EditCategory(category, fbCategoryName.ToValueString(), fbCategoryDescription.ToValueString());
                        ToggleFiltersShowHide(true);
                    });

                ToggleFiltersShowHide(false);
                flpFilter.Controls.Add(fieledBoxBar);
            }
            if ((sender as ComboBox).SelectedItem as string == "X")
            {
                DialogResult result = MessageBox.Show(fa_IR.DeletePrompt, fa_IR.Delete, MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        LMS.DeleteCategory(category);
                    }
                    catch (HasDependancyException)
                    {
                        MessageBox.Show(fa_IR.HasDependancy, fa_IR.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            fieledBoxBar.Cancel += new Action(()=>ToggleFiltersShowHide(true));

        }
        private void comboPublishrControls_SelectedIndexChanged(object sender, EventArgs e)
        {
            UI.FieldBoxBar fieledBoxBar = new UI.FieldBoxBar() { Width = this.Width };

            Publisher publishr= cbPublisher.SelectedValue as Publisher;
            FieldBox fbPublisherName = new FieldBox() { EditMode = true, LabelText = fa_IR.Publisher };

            fieledBoxBar.AddFieldBox(fbPublisherName);

            if ((sender as ComboBox).SelectedItem as string == "+")
            {
                fieledBoxBar.Save += new Action(delegate()
                {
                    LMS.AddNewPublisher(fbPublisherName.ToValueString());
                    ToggleFiltersShowHide(true);
                });

                ToggleFiltersShowHide(false);
                flpFilter.Controls.Add(fieledBoxBar);
            }
            if ((sender as ComboBox).SelectedItem as string == "E")
            {
                fbPublisherName.Text = publishr.PublisherName;
                fieledBoxBar.Save += new Action(delegate()
                {
                    LMS.EditPublisher(publishr, fbPublisherName.ToValueString());
                    ToggleFiltersShowHide(true);
                });

                ToggleFiltersShowHide(false);
                flpFilter.Controls.Add(fieledBoxBar);
            }
            if ((sender as ComboBox).SelectedItem as string == "X")
            {
                DialogResult result = MessageBox.Show(fa_IR.DeletePrompt, fa_IR.Delete, MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        LMS.DeletePublisher(publishr);
                    }
                    catch (HasDependancyException)
                    {
                        MessageBox.Show(fa_IR.HasDependancy, fa_IR.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }

            fieledBoxBar.Cancel += new Action(() => ToggleFiltersShowHide(true));

        }

        private void comboAuthorControls_SelectedIndexChanged(object sender, EventArgs e)
        {
            UI.FieldBoxBar fieledBoxBar = new UI.FieldBoxBar() { Width = this.Width };

            Author author = cbAuthor.SelectedValue as Author;

            
            FieldBox fbAuthorFName = new FieldBox() { EditMode = true, LabelText = fa_IR.FirstName };
            FieldBox fbAuthorLName = new FieldBox() { EditMode = true, LabelText = fa_IR.LastName };
            FieldBox fbAuthorBio = new FieldBox() { EditMode = true, LabelText = fa_IR.Biography };

            fieledBoxBar.AddFieldBox(fbAuthorFName);
            fieledBoxBar.AddFieldBox(fbAuthorLName);
            fieledBoxBar.AddFieldBox(fbAuthorBio);

            if ((sender as ComboBox).SelectedItem as string == "+")
            {
                fieledBoxBar.Save += new Action(delegate()
                {
                    LMS.AddNewAuthor(fbAuthorFName.ToValueString(), fbAuthorLName.ToValueString(), fbAuthorBio.ToValueString());
                    ToggleFiltersShowHide(true);
                });

                ToggleFiltersShowHide(false);
                flpFilter.Controls.Add(fieledBoxBar);
            }
            if ((sender as ComboBox).SelectedItem as string == "E")
            {
                fbAuthorFName.Text = author.FirstName;
                fbAuthorLName.Text = author.LastName;
                fbAuthorBio.Text = author.Biography;
                fieledBoxBar.Save += new Action(delegate()
                {
                    LMS.EditAuthor(author,fbAuthorFName.ToValueString(), fbAuthorLName.ToValueString(), fbAuthorBio.ToValueString());
                    ToggleFiltersShowHide(true);
                });

                ToggleFiltersShowHide(false);
                flpFilter.Controls.Add(fieledBoxBar);
            }
            if ((sender as ComboBox).SelectedItem as string == "X")
            {
                DialogResult result = MessageBox.Show(fa_IR.DeletePrompt, fa_IR.Delete, MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        LMS.DeleteAuthor(author);
                       
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(fa_IR.HasDependancy,fa_IR.Error,MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
            }

            fieledBoxBar.Cancel += new Action(() => ToggleFiltersShowHide(true));
        }

        private void btnShowCheckout_CheckedChanged(object sender, EventArgs e)
        {
            if (checkOutView.Visible)
                checkOutView.Hide();
            else
            {
                bookPanel.Hide();
                checkOutBox.Hide();
                checkOutView.Show();
            }

        }
    }
}
