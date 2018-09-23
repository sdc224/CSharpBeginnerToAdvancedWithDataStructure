using System;

namespace CSharpIntermediate
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString) : base(connectionString)
        {
        }

        public override void OpenConnection()
        {
            Console.WriteLine("Connection opened in Oracle");
        }

        public override void CloseConnection()
        {
            Console.WriteLine("Connection closed in Oracle");
        }
    }
}