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
namespace Library_Management_System
{
    public partial class BookPanel : UserControl
    {
        LibraryMangementSystem LMS;
        public Book CurrentBook
        {
            get;
            set;
        }
        public BookPanel()
        {
            LMS = LibraryMangementSystem.CreateLibraryMangementSystem();
            InitializeComponent();

            fbBookTitle.LabelText = fa_IR.BookTitle;
            fbISBN.LabelText = fa_IR.ISBN;
            fbAuthor.LabelText = fa_IR.Author;
            fbCategory.LabelText = fa_IR.Category;
            fbAbstract.LabelText = fa_IR.BookAbstract;
            fbPublisher.LabelText = fa_IR.Publisher;
            fbPublishYear.LabelText = fa_IR.PublishYear;
            fbNID.LabelText = fa_IR.NID;
            fbLCID.LabelText = fa_IR.LCID;
            fbDCCID.LabelText = fa_IR.DCCID;
            fbNumberOfPages.LabelText = fa_IR.NumberOfPages;
            btnSave.Text = fa_IR.Save;

            Rebind();
        }
        private bool _editMode;
        public bool EditMode
        {
            get
            {
                return _editMode;
            }
            set
            {
                _editMode = value;
                if (EditMode)
                {
                    foreach (Control fieldBox in flpBook.Controls)
                    {
                        btnSave.Show();
                        if (fieldBox is FieldBox)
                            (fieldBox as FieldBox).EditMode = true;
                    }
                }
                else if (!EditMode)
                {
                    btnSave.Hide();
                    foreach (Control fieldBox in flpBook.Controls)
                    {
                        if (fieldBox is FieldBox)
                            (fieldBox as FieldBox).EditMode = false;
                    }
                }
            }
        }
        public void Rebind()
        {
            if (CurrentBook != null)
            {
                
                bind();
            }
        }

        private void bind()
        {
            fbBookTitle.Text = CurrentBook.Title;
            fbBookTitle.DataSource = new List<Book>(LMS.Books);

            fbISBN.Text = CurrentBook.ISBN;
            fbLCID.Text = CurrentBook.LCID;
            fbNID.Text = CurrentBook.NID;
            fbDCCID.Text = CurrentBook.DCCID;

            if (CurrentBook.Category != null)
                fbCategory.Text = CurrentBook.Category.CategoryName;

            fbCategory.EditFieldType = FieldBox.FieldBoxType.ComboBox;
            fbCategory.DataSource = new List<Category>(LMS.Categories);
            //fbCategory.DataSource = LMS.Categories;

            if (CurrentBook.Publisher != null)
                fbPublisher.Text = CurrentBook.Publisher.PublisherName;

            fbPublisher.EditFieldType = FieldBox.FieldBoxType.ComboBox;
            fbPublisher.DataSource = new List<Publisher>(LMS.Publishers);
            //fbPublisher.DataSource = LMS.Publishers;

            if (CurrentBook.Author != null)
                fbAuthor.Text = CurrentBook.Author.FullName;
            fbAuthor.EditFieldType = FieldBox.FieldBoxType.ComboBox;

            fbAuthor.DataSource = new List<Author>(LMS.Authors);
            //fbAuthor.DataSource = LMS.Authors;

            fbPublishYear.Text = CurrentBook.PublishYear.ToString();
            fbNumberOfPages.Text = CurrentBook.NumberOfPages.ToString();
            fbAbstract.Text = CurrentBook.Abstract;
        }
        public BookPanel(Book book)
        {
            InitializeComponent();
            CurrentBook = book;

            Rebind();
        }
        private void flpBook_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditMode = !EditMode;

        }

        private void fbPublisher_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CurrentBook.Id.Equals(Guid.Empty))  //New book
            {
                CurrentBook=LMS.AddNewBook(fbBookTitle.ToValueString(), fbISBN.ToValueString(), fbLCID.ToValueString(), fbNID.ToValueString(), fbDCCID.ToValueString(), fbAbstract.ToValueString(), int.Parse(fbNumberOfPages.ToValueString()), int.Parse(fbPublishYear.ToValueString()), fbCategory.Value as Category, fbPublisher.Value as Publisher, fbAuthor.Value as Author);
                bind();
            }
            {
                LMS.EditBook(CurrentBook, fbBookTitle.ToValueString(), fbISBN.ToValueString(), fbLCID.ToValueString(), fbNID.ToValueString(), fbDCCID.ToValueString(), fbAbstract.ToValueString(), int.Parse(fbNumberOfPages.ToValueString()), int.Parse(fbPublishYear.ToValueString()), fbCategory.Value as Category, fbPublisher.Value as Publisher, fbAuthor.Value as Author);
            }
            EditMode = false;

        }
        private Book _selectedBook;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            EditMode = !EditMode;
            if (EditMode)
            {
                _selectedBook = CurrentBook;
                CurrentBook = new Book();
            }
            else
            {
                CurrentBook = _selectedBook;
            }
              
            bind();


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(fa_IR.DeletePrompt, fa_IR.Delete, MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                LMS.DeleteBook(CurrentBook);
            }
        }

    }
}
