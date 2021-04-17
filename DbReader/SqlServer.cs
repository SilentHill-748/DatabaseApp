using System;
using System.Data;
using System.Data.SqlClient;

namespace DbReader
{
    public class SqlServer : IDatabaseServer
    {
        const string connectionString = "Server=localhost;" +
                                        "Database=ClientsDB;" +
                                        "Integrated Security=True";
        readonly SqlConnection connection;

        public SqlServer()
        {
            Command = string.Empty;
            connection = new SqlConnection(connectionString);
            DataSet = new DataSet();
            Type = ServerType.MSSQL;
        }

        public ServerType Type { get; }

        public string Command { get; set; }

        public DataSet DataSet { get; private set; }

        public void LoadData()
        {
            if (string.IsNullOrWhiteSpace(Command))
                throw new Exception("Не введена комманда!");

            DataSet.Clear();
            using (var command = new SqlCommand(Command, connection))
            {
                connection.Open();
                var adapter = new SqlDataAdapter(command);
                adapter.Fill(DataSet);
                connection.Close();
            }
        }
    }
}
