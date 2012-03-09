using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Disney.iDash.DataLayer;
using System.Data;
using Disney.iDash.BusinessLayer.Properties;

namespace Disney.iDash.BusinessLayer
{
    public class DB2SampleData
    {
        private DB2Factory _factory = new DB2Factory();

        public DataTable GetData(decimal departmentId)
        {
            DataTable table = new DataTable();

            if (_factory.OpenConnection())
                table = _factory.CreateTable(Resources.SQLDetailedWorkbench.Replace("<departmentId>", departmentId.ToString()));

            _factory.CloseConnection();

            return table;
        }
    }
}
