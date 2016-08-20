using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.IO;
namespace DatabaseFactory.XMLFactory
{
    public class XMLHelper : IDatabaseHelper
    {
        private string _fileName;
        public string FileName
        {
            set
            {
                _fileName = value;
            }
            get
            {
                return _fileName;
            }
        }

        private XDocument _document;
        public XDocument Document
        {
            get { return _document; }
            set { _document = value; }
        }

        public XMLHelper()
        {

        }
        public XMLHelper(string fileName)
        {
            FileName = fileName;
            Open(fileName);
        }
        ~XMLHelper()
        {

        }

        #region CRUD Methods
        public void CreateData(IData data)
        {
            this.Open(data.Metadata);

            //Creates data in database
            XElement newNode = null;

            if (data is RawData)
                newNode = XMLData.Parse(data as RawData).Record;
            else
                newNode = ((XMLData)data).Record;

            if (Document.Root == null)
                CreateDatabase(data.Metadata);

            Document.Root.Add(newNode);

            CommitChanges();
            Close();
        }
        public IData RetrieveData(string PKeyValue, DbMetadata meta,bool keepOpen)
        {
            this.Open(meta);

            IEnumerable<XElement> elements = from item in Document.Root.Descendants(meta.EntityName) where item.Element(meta.PrimaryKeyName).Value == PKeyValue select item;

            XMLData xmlData = new XMLData();
            if (elements.Count() > 0)
                xmlData = new XMLData(elements.First());
            else throw new Exception("Key Not Found");

            if(!keepOpen)
                Close();
            return xmlData;
        }
        public IData RetrieveData(string PKeyValue, DbMetadata meta)
        {
            return RetrieveData(PKeyValue, meta, false);
        }
        
        public void UpdateData(IData data, DbMetadata meta)
        {
            

            RawData newData = data as RawData;
            XMLData oldData = (RetrieveData(newData.PrimaryKeyValue, meta,true) as XMLData);
           
            bool noChange = true;

            foreach (KeyValuePair<string, string> newField in newData.Record)
            {
                if (newField.Value == oldData.Record.Element(newField.Key).Value)
                    noChange &= true;
                else
                {
                    oldData.Record.Element(newField.Key).Value = newField.Value;
                    noChange &= false;
                }
            }

            if (!noChange)
            {
                CommitChanges();

            }

            Close();
        }
        public void DeleteData(string PKValue, DbMetadata meta)
        {
            (RetrieveData(PKValue, meta,true) as XMLData).Record.Remove();
            CommitChanges();
            Close();
        }
        #endregion

        public List<IData> RetrieveAll(DbMetadata meta)
        {

            this.Open(meta);

            List<IData> list = new List<IData>();

            if (Document != null &&  Document.Root.Descendants(meta.EntityName).Count()>0)
            {
                IEnumerable<XElement> elements = from item in Document.Root.Elements() where Document.Root.Name == meta.SetName select item;

                foreach (XElement record in elements.Distinct())
                {
                    XMLData data = new XMLData(record);

                    list.Add(data.getRawData());
                }
            }
            Close();
            return list;
        }
        public void CreateDatabase(DbMetadata meta)
        {
            if (!File.Exists(meta.DatabaseName) || Document.Root == null)
            {

                Document = new XDocument();
                Document.Add(new XElement(meta.SetName));
         
                CommitChanges();
            }
        }

        public void Open(string fileName)
        {
            FileName = fileName;
            if (File.Exists(FileName))
                Document = XDocument.Load(FileName);
        }
        public void Open(DbMetadata meta)
        {
            Open(meta.DatabaseName);
            if (Document == null)
                CreateDatabase(meta);
        }
        public void Open()
        {
            Open(FileName);
        }
        public void CommitChanges()
        {
            Document.Save(FileName);
        }
        public void Close()
        {
            Document = null;
        }
    }
}
