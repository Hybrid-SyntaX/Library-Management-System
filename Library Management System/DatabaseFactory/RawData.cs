using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DatabaseFactory
{
    public class RawData : IData<Dictionary<string,string>>, ICloneable
    {
 
        Dictionary<string, string> _record;
        public Dictionary<string, string> Record
        {
            set
            {
                _record=value;
            }
            get
            {
				

                if(_record==null)
                    _record=new Dictionary<string,string>();
                return _record;
            }
        }
       
        private DbMetadata _metadata;
        public DbMetadata Metadata
        {
            get { return _metadata; }
            set { _metadata = value; }
        }
        public object Clone()
        {
            RawData newRawData = new RawData();
            foreach (KeyValuePair<string, string> kvp in this.Record)
            {
                newRawData.Record.Add(kvp.Key, kvp.Value);
            }
            return newRawData;
        }

        public RawData getRawData()
        {
            return this;
        }

        public string PrimaryKeyValue
        {
            get
            {
                return Record[Metadata.PrimaryKeyName];
            }
        }
    }
}
