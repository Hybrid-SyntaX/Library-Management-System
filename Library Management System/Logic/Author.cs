using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DatabaseFactory;
using Validation;

namespace Library_Management_System.Logic
{
    [DbMetadata("Author", "Authors.xml", "Authors", "Id")]
    public class Author : LMSBase
    {
        #region Properties
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
        private string _biography;
        public string Biography
        {
            get { return _biography; }
            set { _biography = value; }
        }

        #endregion

        public Author()
        {


        }
        protected override RawData getData()
        {
            Data.Record["Id"] = Id.ToString();
            Data.Record["FirstName"] = FirstName;
            Data.Record["LastName"] = LastName;
            Data.Record["Biography"] = Biography;

            return Data;
        }
        protected override void setData(RawData data)
        {

            this.Id = parseGuid(data.Record["Id"]);
            this.FirstName = data.Record["FirstName"];
            this.LastName = data.Record["LastName"];
            this.Biography = data.Record["Biography"];

        }
        public override string ToString()
        {
            return FullName;
        }
    }
}
