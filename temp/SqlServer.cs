using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DBReader
{
    public class SqlServer : IDatabaseServer
    {
        public SqlServer()
        {

        }
        public string DataType => "MS SQL Server";

        public string Command { get; set; }

        public DataSet DataSet { get; private set; }


        public void LoadData()
        {
            
        }
    }
}
