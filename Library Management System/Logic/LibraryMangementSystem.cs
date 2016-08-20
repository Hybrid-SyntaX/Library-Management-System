using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library_Management_System.Logic
{
    public enum SearchOperand
    {
        AND,
        OR
    }
    public class HasDependancyException : ApplicationException
    {

    }
    public delegate void LMSEventHandler(object sender, LMSEventArgs e);
    public class LMSEventArgs : EventArgs
    {
        public LMSEventArgs()
        {

        }
        public LMSEventArgs(string entityName)
        {
            EntityName = entityName;
        }
        public string EntityName { set; get; }
    }
    public class LibraryMangementSystem
    {
        private List<Author> _authors;
        private List<Publisher> _publishers;
        private List<Category> _categories;
        private List<Book> _books;
        private List<Borrower> _borrowers;
        private List<CheckOut> _checkOuts;

        public List<Author> Authors { get { return _authors; } }
        public List<Publisher> Publishers { get { return _publishers; } }
        public List<Category> Categories { get { return _categories; } }
        public List<Book> Books { get { return _books; } }
        public List<Borrower> Borrowers { get { return _borrowers; } }
        public List<CheckOut> CheckOuts { get { return _checkOuts; } }


        private static LibraryMangementSystem _libraryManagementSystem;
        
        private LibraryMangementSystem()
        {
            _authors = Author.ReadAll<Author>();
            _publishers = Publisher.ReadAll<Publisher>();
            _categories = Category.ReadAll<Category>();
            _books = Book.ReadAll<Book>();
            _borrowers = Borrower.ReadAll<Borrower>();
            _checkOuts = CheckOut.ReadAll<CheckOut>();

        }
        public static LibraryMangementSystem CreateLibraryMangementSystem()
        {
            if (_libraryManagementSystem == null)
                _libraryManagementSystem = new LibraryMangementSystem();

            return _libraryManagementSystem;
        }

        public void SubmitCheckOut(Borrower borrower, List<Book> books, DateTime dueDate)
        {
            CheckOut checkout = new CheckOut();

            checkout.Borrower = borrower;
            checkout.BorrowDate = DateTime.UtcNow;
            checkout.Status = CheckOutStatus.CheckedOut;
            checkout.DueDate = dueDate;
            checkout.Books.AddRange(books);
            checkout.Save();

            _checkOuts.Add(checkout);
        }
        public void ReturnBooks(CheckOut checkOut, DateTime returnDate)
        {
            checkOut.ReturnDate = returnDate;
            checkOut.Status = CheckOutStatus.Returned;
            checkOut.Edit();

        }
        public List<CheckOut> FilterCheckOuts(Borrower borrower)
        {
            return (from CheckOut checkOut in CheckOuts where checkOut.Borrower.Id.Equals(borrower.Id) select checkOut).ToList();
        }

        public event LMSEventHandler DataSourceChanged;

        public void AddNewBorrower(int userId, string firstName, string lastName, DateTime birthDate)
        {
            Borrower borrower = new Borrower();
            borrower.FirstName = firstName;
            borrower.LastName = lastName;
            borrower.UserId = userId;
            borrower.BirthDate = birthDate;
            borrower.RegistrationDate = DateTime.Now;
            borrower.Save();
            reloadBorrowers();
        }
        public void DeleteBorrower(Borrower borrower)
        {
            borrower.Delete();
            reloadBorrowers();
        }
        public void EditBorrower(Borrower borrower)
        {
            borrower.Edit();
            reloadBorrowers();
        }
        private void reloadBorrowers()
        {
            _borrowers = Borrower.ReadAll<Borrower>();
        }


        public Book AddNewBook(string title, string isbn, string lcid, string nid, string dccid, string bookAbstract, int numberOfPages, int publishYear, Category category, Publisher publisher, Author author)
        {
            Book book = new Book();
            book.Title = title;
            book.ISBN = isbn;
            book.LCID = lcid;
            book.NID = nid;
            book.DCCID = dccid;
            book.PublishYear = publishYear;
            book.Abstract = bookAbstract;
            book.NumberOfPages = numberOfPages;
            book.Category = category;
            book.Author = author;
            book.Publisher = publisher;

            book.Save();
            reloadBooks();

            return book;
        }
        public void AddNewBook(string title, string isbn, string lcid, string nid, string dccid, string bookAbstract, int numberOfPages, int publishYear, string categoryName, string publisherName, string authorName)
        {
            Category cateogry = (from Category c in Categories where c.CategoryName == categoryName select c).First<Category>();
            Publisher publisher = (from Publisher p in Publishers where p.PublisherName==publisherName select p).First<Publisher>();
            Author author = (from Author a in Authors where a.FullName == authorName select a).First<Author>();

            AddNewBook(title, isbn, lcid, nid, dccid, bookAbstract, numberOfPages, publishYear, cateogry, publisher, author);

        }
        public void EditBook(Book book,string title, string isbn, string lcid, string nid, string dccid, string bookAbstract, int numberOfPages, int publishYear, Category category, Publisher publisher, Author author)
        {
            book.Title = title;
            book.ISBN = isbn;
            book.LCID = lcid;
            book.NID = nid;
            book.DCCID = dccid;
            book.PublishYear = publishYear;
            book.Abstract = bookAbstract;
            book.NumberOfPages = numberOfPages;
            book.Category = category;
            book.Author = author;
            book.Publisher = publisher;

            book.Edit();
            reloadBooks();

        }
        public void EditBook(Book book, string title, string isbn, string lcid, string nid, string dccid, string bookAbstract, int numberOfPages, int publishYear, string categoryName, string publisherName, string authorName)
        {
            Category cateogry = (from Category c in Categories where c.CategoryName == categoryName select c).First<Category>();
            Publisher publisher = (from Publisher p in Publishers where p.PublisherName == publisherName select p).First<Publisher>();
            Author author = (from Author a in Authors where a.FullName == authorName select a).First<Author>();

            EditBook(book, title, isbn, lcid, nid, dccid, bookAbstract, numberOfPages, publishYear, cateogry, publisher, author);

        }
        public void DeleteBook(Book book)
        {
            book.Delete();
            reloadBooks();
        }
        private void reloadBooks()
        {
            _books = Book.ReadAll<Book>();
            DataSourceChanged(Books, new LMSEventArgs("Book"));
        }

        public void AddNewCategory(string categoryName, string categoryDescription)
        {
            Category category = new Category();
            category.CategoryName = categoryName;
            category.Description = categoryDescription;
            category.Save();
            reloadCategories();
        }
        public void EditCategory(Category category, string categoryName, string categoryDescription)
        {
            category.CategoryName = categoryName;
            category.Description = categoryDescription;
            category.Edit();
            reloadCategories();
        }
        public void DeleteCategory(Category category)
        {
            if (Book.ReadByCategory(category).Count == 0)
            {
                category.Delete();
                reloadCategories();
            }
            else throw new HasDependancyException();
        }
        private void reloadCategories()
        {
            _categories = Category.ReadAll<Category>();
            DataSourceChanged(Categories, new LMSEventArgs("Category"));
        }

        public void AddNewPublisher(string publisherName)
        {
            Publisher publisher = new Publisher();
            publisher.PublisherName = publisherName;
            publisher.Save();
            reloadPublishers();
        }
        public void EditPublisher(Publisher publisher, string publisherName)
        {
            publisher.PublisherName = publisherName;
            publisher.Edit();
            reloadPublishers();
        }
        public void DeletePublisher(Publisher publisher)
        {
            if (Book.ReadByPublisher(publisher).Count == 0)
            {
                publisher.Delete();
                reloadPublishers();
            }
            else throw new HasDependancyException();
        }
        private void reloadPublishers()
        {
            _publishers = Publisher.ReadAll<Publisher>();
            DataSourceChanged(Publishers, new LMSEventArgs("Publisher"));
        }

        public void AddNewAuthor(string firstName, string lastName, string biography)
        {
            Author author = new Author();
            author.FirstName = firstName;
            author.LastName = lastName;
            author.Biography = biography;
            author.Save();
            reloadAuthors();
        }
        public void EditAuthor(Author author, string firstName, string lastName, string biography)
        {
            author.FirstName = firstName;
            author.LastName = lastName;
            author.Biography = biography;
            author.Edit();
            reloadAuthors();
        }
        public void DeleteAuthor(Author author)
        {
            if (Book.ReadByAuthor(author).Count == 0)
            {
                author.Delete();
                reloadAuthors();
            }
            else throw new HasDependancyException();
        }
        private void reloadAuthors()
        {
            
            _authors = Author.ReadAll<Author>();
            DataSourceChanged(Authors, new LMSEventArgs("Author"));
        }

  
        public List<Book> FilterBooks(Category category, Publisher publisher, Author author, string q, SearchOperand op)
        {
            List<Book> filteredBooks = Book.Search(q);
            if (author != null || publisher != null || category != null)
            {


                if (op == SearchOperand.AND)
                    filteredBooks = (from Book b in Book.Search(q) 
                                     where
                                         (author == null || b.Author.Equals(author)) &&
                                         (category == null || b.Category.Equals(category)) &&
                                         (publisher == null || b.Publisher.Equals(publisher))
                                     select b).ToList<Book>();
                else
                    filteredBooks = (from Book b in Book.Search(q)
                                     where
                                         (author == null || b.Author.Equals(author)) ||
                                         (category == null || b.Category.Equals(category)) ||
                                         (publisher == null || b.Publisher.Equals(publisher))
                                     select b).ToList<Book>();

            }

            return filteredBooks;
        }
    }
}
