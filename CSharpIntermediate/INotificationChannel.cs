namespace CSharpIntermediate
{
    public interface INotificationChannel
    {
        void Send(Message message);
    }
}