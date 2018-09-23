using System;

namespace CSharpIntermediate
{
    public class SmsNotificationChannel : INotificationChannel
    {
        public void Send(Message message)
        {
            Console.WriteLine("Sending sms...");
        }
    }
}