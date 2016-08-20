using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DatabaseFactory
{
    public abstract class Base: IBase
    {
        
        
        private static IDatabaseHelper _databaseHelper;
        protected static IDatabaseHelper DatabaseHelper
        {
            get
            {
                return _databaseHelper;
            }
            set
            {
                _databaseHelper = value;
            }
        }

        protected abstract RawData getData();
        protected abstract void setData(RawData data);

        private RawData _data;
        protected RawData Data
        {
            get
            {
                if (_data == null)
                    _data = new RawData();

                return _data;
            }
            set
            {
                _data = value;
            }
        }
    
        protected static DbMetadata getDbMetadata(Type t)
        {
           
            if (t.GetCustomAttributes(typeof(DbMetadata), true).Count() > 0)
                return t.GetCustomAttributes(typeof(DbMetadata), true)[0] as DbMetadata;
            else throw new NotImplementedException("DbMetadata is not implemented");
        }
        protected static DbMetadata getDbMetadata(object obj)
        {
            return getDbMetadata(obj.GetType());
        }

        public abstract void Save();

        public abstract IBase Read(string PK);

        public abstract void Delete();

        public abstract void Edit();

    }
}
