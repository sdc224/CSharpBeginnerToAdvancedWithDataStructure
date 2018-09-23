using System;

namespace CSharpIntermediate
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString) : base(connectionString)
        {
        }

        public override void OpenConnection()
        {
            Console.WriteLine("Connection opened in Sql Server");
        }

        public override void CloseConnection()
        {
            Console.WriteLine("Connection closed in Sql Server");
        }
    }
}