using System;

namespace CSharpIntermediate
{
    public class SendEmail : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Sending Email...");
        }
    }
}