using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using DatabaseFactory;
using DatabaseFactory.XMLFactory;

namespace Library_Management_System.Logic
{
    public abstract class LMSBase : Base
    {
        static LMSBase()
        {
            DatabaseHelper = new XMLHelper();
        }

        public LMSBase()
        {
            Data.Metadata = getDbMetadata(this);
            (DatabaseHelper as XMLHelper).FileName = Data.Metadata.DatabaseName;
        }

        private Guid _id;
        public Guid Id
        {
            get
            {
                if (_id == null)
                    _id = new Guid();

                return _id;
            }
            set
            {
                if (_id == Guid.Empty)
                    _id = value;
            }
        }

        protected Guid parseGuid(string guidString)
        {
            Guid guid;
            Guid.TryParse(guidString, out guid);

            return guid;
        }
        #region CRUD Methods
        public override void Save()
        {
            if (Id == Guid.Empty)
                Id = Guid.NewGuid();

            DatabaseHelper.CreateData(this.getData());
        }    
        public override IBase Read(string key)
        {
            
            if (Guid.Parse(key) != Guid.Empty)
                setData(DatabaseHelper.RetrieveData(key, Data.Metadata).getRawData());
            else throw new Exception("Invalid Key");
            
            return this;
        }
        public override void Edit()
        {
            DatabaseHelper.UpdateData(this.getData(), Data.Metadata);
        }
        public override void Delete()
        {
            DatabaseHelper.DeleteData(Id.ToString(), Data.Metadata);
        }

        public static List<T> ReadAll<T>() where T : LMSBase, IBase, new()
        {

            DbMetadata meta = getDbMetadata(typeof(T));
            
            List<IData> records = DatabaseHelper.RetrieveAll(meta);

            List<T> all = new List<T>();
            foreach (RawData  data in records)
            {
                T obj = new T();
               
                obj.setData(data.getRawData());
                all.Add(obj);
            }
            
            return all;
        }

        public static  IEnumerable<T> Query<T>(Func<T,bool> preidicate) where T: LMSBase, new()
        {
            IEnumerable<T> query = from T a in ReadAll<T>().Where(preidicate) select a;

            
            return query;

        }
        public override bool Equals(object obj)
        {
            if (obj as LMSBase == null)
            {
                return false;
            }

            return Id.Equals((obj as LMSBase).Id);
        }
        public override int GetHashCode()
        {
            return this.GetHashCode();
        }

        #endregion
    }
}