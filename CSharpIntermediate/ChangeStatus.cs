using System;

namespace CSharpIntermediate
{
    public class ChangeStatus : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Changing the status...");
        }
    }
}