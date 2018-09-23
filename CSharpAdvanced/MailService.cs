using System;

namespace CSharpAdvanced
{
    public class MailService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("Sending email . . ." + e.Video.Name);
        }
    }
}