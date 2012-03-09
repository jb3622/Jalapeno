using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Disney.iDash.DataLayer;
using System.Data;
using Disney.iDash.Shared;

namespace Disney.iDash.BusinessLayer
{
    public sealed class DataSources
    {

        public ExceptionHandler ExceptionHandler = new ExceptionHandler();

        private DB2Factory _factory = new DB2Factory();

        public DataSources()
        {
            _factory.ExceptionHandler.OnException += ((ex, extraInfo, terminateApplication) =>
                {
                    ExceptionHandler.RaiseException(ex, extraInfo, terminateApplication);
                });
        }

        private DataTable GetData(string sql)
        {
            var table = new DataTable();
            if (_factory.OpenConnection())
                try
                {
                    table = _factory.CreateTable(sql);
                }
                catch (Exception ex)
                {
                    ExceptionHandler.RaiseException(ex, "GetData");
                }
            return table;
        }

        public DataTable GetStoreData(WorkbenchInfo workbenchInfo)
        {
            var return null;
        }

        public DataTable GetClassData(WorkbenchInfo workbenchInfo)
        {
            var sql = Properties.Resources.SQLClassSelector;
            return GetData(sql);
        }
    }
}
