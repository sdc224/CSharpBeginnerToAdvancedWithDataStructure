using System;

namespace CSharpIntermediate
{
    public class VideoUpload : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Uploading the video...");
        }
    }
}