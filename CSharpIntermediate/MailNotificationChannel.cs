using System;

namespace CSharpIntermediate
{
    public class MailNotificationChannel : INotificationChannel
    {
        public void Send(Message message)
        {
            Console.WriteLine("Sending Email...");
        }
    }
}