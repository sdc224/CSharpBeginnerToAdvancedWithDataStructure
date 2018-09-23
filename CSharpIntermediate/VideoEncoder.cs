using System.Collections.Generic;

namespace CSharpIntermediate
{
    public class VideoEncoder
    {
        private readonly IList<INotificationChannel> _notificationChannels;

        public VideoEncoder()
        {
            _notificationChannels = new List<INotificationChannel>();
        }

        public VideoEncoder(IList<INotificationChannel> notificationChannels)
        {
            _notificationChannels = notificationChannels;
        }

        public void RegisterNotificationChannel(INotificationChannel channel)
        {
            _notificationChannels.Add(channel);
        }

        public void Encode(Video video)
        {
            foreach (var channel in _notificationChannels)
            {
                channel.Send(new Message());
            }
        }
    }
}