using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DatabaseFactory;


namespace Library_Management_System.Logic
{
    [DbMetadata("Borrower", "Borrowers.xml", "Borrowers", "Id")]
    public class Borrower : LMSBase
    {

        private string _firstName;
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }

        private string _lastName;
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }

        public string FullName
        {
            get
            {
                return string.Format("{0} {1}", FirstName, LastName);
            }
        }
        private int _userId;
        public int UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }

        
        private DateTime _birthDate;
        public DateTime BirthDate
        {
            get { return _birthDate; }
            set { _birthDate = value; }
        }

        private DateTime _registrationDate;
        public DateTime RegistrationDate
        {
            get { return _registrationDate; }
            set { _registrationDate = value; }
        }

        public Borrower()
        {

        }
        protected override RawData getData()
        {

            Data.Record["Id"] = Id.ToString();
            Data.Record["UserId"] = UserId.ToString();  //find a way to generate UserId--> BirthDate+ RegistrationDate
            Data.Record["FirstName"] = FirstName;
            Data.Record["LastName"] = LastName;
            Data.Record["RegistrationDate"] = RegistrationDate.ToUniversalTime().ToString();
            Data.Record["BirthDate"] = RegistrationDate.ToUniversalTime().ToString();

            return Data;
        }
        protected override void setData(RawData data)
        {
            this.Id = parseGuid(data.Record["Id"]);
            this.UserId = int.Parse(data.Record["UserId"]);
            this.FirstName = data.Record["FirstName"];
            this.LastName = data.Record["LastName"];

            if (!string.IsNullOrEmpty(data.Record["RegistrationDate"]))
                this.RegistrationDate = DateTime.Parse(data.Record["RegistrationDate"]);
            
            if (!string.IsNullOrEmpty(data.Record["BirthDate"]))
                this.BirthDate = DateTime.Parse(data.Record["BirthDate"]);

        }
        public override string ToString()
        {
            return FullName;
        }
    }
}
