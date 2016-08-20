using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DatabaseFactory
{
    public interface IData
    {
        
        DbMetadata Metadata
        {
            get;
            set;
        }
        RawData getRawData();
    }
    public interface IData<T> : IData
    {
        T Record
        {
            set;
            get;
        }
    }
}
