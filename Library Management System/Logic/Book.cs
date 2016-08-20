using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DatabaseFactory;
namespace Library_Management_System.Logic
{
    [DbMetadata("Book", "Books.xml", "Books", "Id")]
    public class Book : LMSBase
    {
        #region Properties
        private string _title;
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        private Category _category;
        public Category Category
        {
            get { return _category; }
            set { _category = value; }
        }

        private Author _author;
        public Author Author
        {
            get { return _author; }
            set { _author = value; }
        }

        private Publisher _publisher;
        public Publisher Publisher
        {
            get { return _publisher; }
            set { _publisher = value; }
        }

        private string _isbn;
        public string ISBN
        {
            get { return _isbn; }
            set { _isbn = value; }
        }

        private int _publishYear;
        public int PublishYear
        {
            get { return _publishYear; }
            set { _publishYear = value; }
        }

        private int _numberOfPages;
        public int NumberOfPages
        {
            get { return _numberOfPages; }
            set { _numberOfPages = value; }
        }

        private string _abstract;
        public string Abstract
        {
            get { return _abstract; }
            set { _abstract = value; }
        }

        private string _lcid;
        public string LCID
        {
            get { return _lcid; }
            set { _lcid = value; }
        }
        private string _dccid;
        public string DCCID
        {
            get { return _dccid; }
            set { _dccid = value; }
        }

        private string _nid;
        public string NID
        {
            get { return _nid; }
            set { _nid = value; }
        }

        #endregion
        protected override void setData(RawData data)
        {
            this.Id = parseGuid(data.Record["Id"]);
            this.LCID = data.Record["LCID"];
            this.DCCID = data.Record["DCCID"];
            this.NID = data.Record["NID"];
            this.Title = data.Record["Title"];
            this.Abstract = data.Record["Abstract"];
            
            this.Publisher = new Publisher();
            this.Publisher.Read(data.Record["PublisherId"]);
            this.Author = new Author();
            this.Author.Read(data.Record["AuthorId"]);
            this.Category = new Category();
            this.Category.Read(data.Record["CategoryId"]);
          
            this.ISBN = data.Record["ISBN"];
            this.NumberOfPages = int.Parse(data.Record["NumberOfPages"]);
            this.PublishYear = int.Parse(data.Record["PublishYear"]);
        }
        protected override RawData getData()
        {

            Data.Record["Id"] = Id.ToString();
            Data.Record["LCID"] = LCID;
            Data.Record["DCCID"] = DCCID;
            Data.Record["NID"] = NID;
            Data.Record["Title"] = Title;
            Data.Record["Abstract"] = Abstract;
            Data.Record["PublisherId"] = Publisher.Id.ToString();
            Data.Record["AuthorId"] = this.Author.Id.ToString();
            Data.Record["CategoryId"] = Category.Id.ToString();
            Data.Record["ISBN"] = ISBN.ToString();
            Data.Record["NumberOfPages"] = NumberOfPages.ToString();
            Data.Record["PublishYear"] = this.PublishYear.ToString();

            return Data;

        }
        public static List<Book> Search(string q)
        {
            /*
                                b.Title.ToLowerInvariant().Contains(q) ||
                                b.Abstract.ToLowerInvariant().Contains(q) ||
                                b.Publisher.PublisherName.ToLowerInvariant().Contains(q) ||
                                b.Author.FullName.ToLowerInvariant().Contains(q)
             */
            return Query(
                (Book b) => b.Title.ToLowerInvariant().Contains(q)
            ).ToList<Book>();
        }
        public static List<Book> ReadByCategory(Category category)
        {
            return Query(
                (Book b) => b.Category.Id.Equals(category.Id)
            ).ToList<Book>();
        }
        public static List<Book> ReadByAuthor(Author author)
        {
            return Query(
                (Book b) => b.Author.Id.Equals(author.Id)
            ).ToList<Book>();
        }
        public static List<Book> ReadByPublisher(Publisher publisher)
        {
            return Query(
                (Book b) => b.Publisher.Id.Equals(publisher.Id)
            ).ToList<Book>();
        }
        public override string ToString()
        {
            return Title;
        }
    }
}
