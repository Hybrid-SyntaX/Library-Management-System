using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DatabaseFactory;
namespace Library_Management_System.Logic
{
    [DbMetadata("Category", "Categories.xml", "Categories", "Id")]
    public class Category : LMSBase
    {

        private string _categoryName;
        public string CategoryName
        {
            get
            {
                return _categoryName;
            }
            set
            {
                _categoryName = value;
            }
        }

        private string _description;
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public Category()
        {

        }
        protected override RawData getData()
        {
            
            Data.Record["Id"] = Id.ToString();
            Data.Record["CategoryName"] = CategoryName;

            return Data;
        }
        protected override void setData(RawData data)
        {
            if (data.Record.Count > 0)
            {
                this.Id = parseGuid(data.Record["Id"]);
                this.CategoryName = data.Record["CategoryName"];
            }
        }
        public override string ToString()
        {
            return CategoryName;
        }

    }
}
