using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
namespace DatabaseFactory.XMLFactory
{
    public class XMLData : IData<XElement>
    {

        /// <summary>
        /// Convert XML record to RawData
        /// </summary>
        /// <returns></returns>
        public RawData getRawData()
        {
            RawData rawData = new RawData();

            if (this.Record != null)
                foreach (XElement ele in this.Record.Elements())
                {
                    rawData.Record[ele.Name.LocalName] = ele.Value;
                }

            return rawData;
        }

        private DbMetadata _dbMetadata;
        public DbMetadata Metadata
        {
            get { return _dbMetadata; }
            set { _dbMetadata = value; }
        }

        public static explicit operator XMLData(RawData data)
        {

            return XMLData.Parse(data);
        }

        public static XMLData Parse(RawData data)
        {
            XMLData xmlData = new XMLData(data.Metadata);

            foreach (KeyValuePair<string, string> field in data.Record)
            {
                xmlData.Record.Add(new XElement(field.Key, field.Value));
            }

            return xmlData;
        }
        public XMLData()
        {
        }
        public XMLData(DbMetadata metadata)
        {
            this.Metadata = metadata;
        }
        public XMLData(XElement xelement)
        {
            Record = xelement;
        }

        private XElement _record;
        public XElement Record
        {
            set
            {
                _record = value;
            }
            get
            {
                if (_record == null && Metadata != null && !string.IsNullOrEmpty(Metadata.EntityName))
                    _record = new XElement(Metadata.EntityName);

                return _record;
            }
        }

        private XElement _root;
        public XElement Root
        {
            set
            {
                _root = value;
            }
            get
            {
                if (_root == null && !string.IsNullOrEmpty(Metadata.SetName))
                    _root = new XElement(Metadata.SetName);
                return _root;
            }
        }

    }

}
