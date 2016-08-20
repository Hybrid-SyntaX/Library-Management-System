using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DatabaseFactory;

namespace Library_Management_System
{
    [DbMetadata("Libarian","Libarians.xml","Libarians","Id")]
    public class Librarian
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

        private string _username;
        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }

        private string _password;
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public void Authenticate()
        {
        }
    }
}
