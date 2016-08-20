using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DatabaseFactory
{
    public interface IBase
    {

        #region CRUD Methods
        void Save();
        IBase Read(string key);
        void Delete();
        void Edit();
        #endregion

    }
}
