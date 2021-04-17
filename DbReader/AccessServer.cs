using System;
using System.Data;
using System.Data.OleDb;

namespace DbReader
{
    public class AccessServer : IDatabaseServer
    {
        private static string pathToDb = @"D:\Кодинг\Проекты C# (VS Community)\Практика и уроки\Database App\clients.accdb";
        private string connectionString = "Provider=Microsoft.Ace.OLEDB.12.0;" +
                                          $"Data Source={pathToDb}";
        private readonly OleDbConnection connection;

        public AccessServer()
        {
            Command = string.Empty;
            connection = new OleDbConnection(connectionString);
            DataSet = new DataSet();
            Type = ServerType.Access;
        }

        public ServerType Type { get; }

        public string Command { get; set; }

        public DataSet DataSet { get; private set; }

        public void LoadData()
        {
            if (string.IsNullOrWhiteSpace(Command))
                throw new Exception("Не введена комманда!");

            DataSet.Clear();
            using (var command = new OleDbCommand(Command, connection))
            {
                connection.Open();
                var adapter = new OleDbDataAdapter(command);
                adapter.Fill(DataSet);
                connection.Close();
            }
        }
    }
}
