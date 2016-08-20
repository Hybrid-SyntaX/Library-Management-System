using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DatabaseFactory;
namespace Library_Management_System.Logic
{
    [DbMetadata("CheckOut", "CheckOuts.xml", "CheckOuts", "Id")]
    public class CheckOut : LMSBase
    {
        private Borrower _borrower;
        public Borrower Borrower
        {
            get { return _borrower; }
            set { _borrower = value; }
        }

        private CheckOutStatus _status;
        public CheckOutStatus Status
        {
            get { return _status; }
            set { _status = value; }
        }

        private DateTime _borrowDate;
        public DateTime BorrowDate
        {
            get { return _borrowDate; }
            set { _borrowDate = value; }
        }

        private DateTime _returnDate;
        public DateTime ReturnDate
        {
            get { return _returnDate; }
            set { _returnDate = value; }
        }

        private DateTime _dueDate;
        public DateTime DueDate
        {
            get { return _dueDate; }
            set { _dueDate = value; }
        }



        private List<Book> _books;
        public List<Book> Books
        {
            get
            {
                if (_books == null)
                    _books = new List<Book>();
                return _books;
            }
            set { _books = value; }
        }

        int _loanPeriod;

        public int LoanPeriod
        {
            get { return _loanPeriod; }
            set { _loanPeriod = value; }
        }
        public CheckOut()
        {

        }

        protected override RawData getData()
        {
            Data.Record["Id"] = Id.ToString();
            Data.Record["BorrowerId"] = Borrower.Id.ToString();
            Data.Record["BorrowDate"] = BorrowDate.ToUniversalTime().ToString();
            Data.Record["ReturnDate"] = ReturnDate.ToUniversalTime().ToString();
            Data.Record["DueDate"] = DueDate.ToUniversalTime().ToString();
            Data.Record["BorrowStatus"] = ((int)Status).ToString();
            Data.Record["Books"] = string.Join<Guid>(",", Books.Select((LMSBase b) => b.Id));

            return Data;
        }
        protected override void setData(RawData data)
        {
            this.Id = parseGuid(data.Record["Id"]);
            this.Borrower = new Borrower().Read(data.Record["BorrowerId"]) as Borrower;

            if (!string.IsNullOrEmpty(data.Record["BorrowDate"]))
                this.BorrowDate = DateTime.Parse(data.Record["BorrowDate"]);
            if (!string.IsNullOrEmpty(data.Record["DueDate"]))
                this.DueDate = DateTime.Parse(data.Record["DueDate"]);
            if (!string.IsNullOrEmpty(data.Record["ReturnDate"]))
                this.ReturnDate = DateTime.Parse(data.Record["ReturnDate"]);

            this.Status = (CheckOutStatus)int.Parse(data.Record["BorrowStatus"]);

            IEnumerable<Book> books = from string id in data.Record["Books"].Split(',') select new Book().Read(id) as Book;
            this.Books = books.ToList();
        }
    }
}
