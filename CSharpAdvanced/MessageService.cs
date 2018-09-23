using System;

namespace CSharpAdvanced
{
    public class MessageService
    {
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine("Sending a sms . . ." + args.Video.Name);
        }
    }
}
