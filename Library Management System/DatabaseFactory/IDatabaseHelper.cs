using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DatabaseFactory
{
    public interface IDatabaseHelper
    {
        void CreateData(IData data);
        IData RetrieveData(string PKeyValue, DbMetadata meta);
        List<IData> RetrieveAll(DbMetadata meta);
        void UpdateData(IData data, DbMetadata meta);
        void DeleteData(string PKValue, DbMetadata meta);

        void CreateDatabase(DbMetadata meta);
        void CommitChanges();

        void Open(string connectionString);
        void Open(DbMetadata meta);
        void Open();
        void Close();
    }
}
