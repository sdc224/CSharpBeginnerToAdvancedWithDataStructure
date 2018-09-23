using System;

namespace CSharpIntermediate
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; private set; }
        public TimeSpan Timeout { get; set; }

        protected DbConnection(string connectionString)
        {
            if(string.IsNullOrWhiteSpace(connectionString))
                throw new NotImplementedException("Connection String can not be null");

            ConnectionString = connectionString;
        }

        public abstract void OpenConnection();
        public abstract void CloseConnection();
    }
}