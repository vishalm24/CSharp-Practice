using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegatesDemo
{
    public class VideoEventArgs: EventArgs
    {
        public Video Video { get; set; }
    }
    internal class VideoEncoder
    {
        public delegate void VideoEncoderEventHandler(object source, VideoEventArgs args);
        public event VideoEncoderEventHandler VideoEncoded;
        public void Encode(Video video)
        {
            Console.WriteLine("Video encoding has been started...");
            Thread.Sleep(3000);
            OnVideoEncoded(video);
        }
        protected virtual void OnVideoEncoded(Video video)
        {
            if(VideoEncoded != null)
            {
                VideoEncoded(this, new VideoEventArgs() { Video = video });
            }
        }
    }
}
