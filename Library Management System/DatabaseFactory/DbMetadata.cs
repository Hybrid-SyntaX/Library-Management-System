using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DatabaseFactory
{
    public class DbMetadata : Attribute
    {
        public DbMetadata(string entityName, string databaseName, string setName, string primaryKeyName)
        {
            if (string.IsNullOrEmpty(entityName) || string.IsNullOrEmpty(setName) || string.IsNullOrEmpty(primaryKeyName) || string.IsNullOrEmpty(databaseName))
            {
                throw new Exception("Invalid Values");
            }
            EntityName = entityName;
            SetName = setName;
            PrimaryKeyName = primaryKeyName;
            DatabaseName = databaseName;
        }
        
        private string _entityName;
        public string EntityName
        {
            get { return _entityName; }
            set { _entityName = value; }
        }
        
        private string _setName;
        public string SetName
        {
            get { return _setName; }
            set { _setName = value; }
        }
        
        private string _primaryKeyName;
        public string PrimaryKeyName
        {
            get { return _primaryKeyName; }
            set { _primaryKeyName = value; }
        }

        private string _databaseName;
        public string DatabaseName
        {
            get { return _databaseName; }
            set { _databaseName = value; }
        }
    }
}
