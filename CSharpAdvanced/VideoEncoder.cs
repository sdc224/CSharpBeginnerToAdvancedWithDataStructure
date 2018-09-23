using System;
using System.Threading;

namespace CSharpAdvanced
{
    public class VideoEncoder
    {
        /*
         * To give a class the ability to publish an event, we have to follow 3 steps
         * 1- Define a delegate
         * 2- Define an event based on that delegate
         * 3- Raise the event
         */

        // Step 1
        public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);

        // Step 2
        public event VideoEncodedEventHandler VideoEncoded;

        // Wthout step 1
        //public EventHandler<VideoEventArgs> VideoEncoded;

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding the video . . .");
            Thread.Sleep(3000);
            OnVideoEncoded(video);
        }

        // Step 3
        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded != null)
                VideoEncoded(this, new VideoEventArgs {Video = video});
        }
    }
}