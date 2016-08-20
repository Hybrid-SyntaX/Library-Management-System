using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DatabaseFactory;
namespace Library_Management_System.Logic
{
    [DbMetadata("Publisher","Publishers.xml","Publishers","Id")]
    public class Publisher : LMSBase
    {
       
        public Publisher()
        {
            
        }
        private string _publisherName;
        public string PublisherName
        {
            get
            {
                return _publisherName;
            }
            set
            {
                _publisherName = value;
            }
        }
        protected override RawData getData()
        {

            Data.Record["Id"]=Id.ToString();
            Data.Record["PublisherName"] = PublisherName; ;

            return Data;

        }
        protected override void setData(RawData data)
        {
            this.Id = parseGuid(data.Record["Id"]);
            this.PublisherName = data.Record["PublisherName"];
            
        }
        public override string ToString()
        {
            return PublisherName;
        }
    }
}
