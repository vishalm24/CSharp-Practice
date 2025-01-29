using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegatesDemo3
{
    public class VideoEventArgs: EventArgs
    {
        public Video Video { get; set; }
    }
    internal class VideoEncoder
    {
        public delegate void VideoEncoderEventHandler(object source, VideoEventArgs args);
        public event VideoEncoderEventHandler VideoEncoded;
        public void VideoEncode(Video video)
        {
            Console.WriteLine("Encoding Video has been started...");
            Thread.Sleep(3000);
            OnDemandVideo(video);
        }
        protected virtual void OnDemandVideo(Video video)
        {
            if(VideoEncode != null)
            {
                VideoEncoded(this, new VideoEventArgs() { Video = video });
            }
        }
    }
}
