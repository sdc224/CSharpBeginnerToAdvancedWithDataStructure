using System;

namespace CSharpIntermediate
{
    public class DbCommand
    {
        public DbConnection DbConnection { get; private set; }
        public string Instruction { get; private set; }

        public DbCommand(DbConnection dbConnection, string instruction)
        {
            if(string.IsNullOrWhiteSpace(instruction))
                throw new NotImplementedException("Instrction cannot be null");

            DbConnection = dbConnection ?? throw new NotImplementedException("Database connection cannot be null");
            Instruction = instruction;
        }

        public void Execute()
        {
            DbConnection.OpenConnection();
            Console.WriteLine("Connection is running on {0} instuction at {1} timeout", Instruction, DbConnection.Timeout);
            DbConnection.CloseConnection();
        }
    }
}