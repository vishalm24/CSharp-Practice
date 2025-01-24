using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    public class VideoEventArgs: EventArgs
    {
        public Video Video{ get; set; }
    }
    public class VideoEncoder
    {
        //1. Define a delegate
        //EventHandler in VideoEncodedEventHandler is naming convention for defining delegate for event.
        public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);
        //We don't have to use above statement. As Dot Net grew, they added new feature of event:
        //public event EventHandler<VideoEventArgs> VideoEncoded;
        //// This is for passing parameter. In our case we have Video video.
        //public event EventHandler VideoEncoded;
        //// This is for No parameter as above code.
        //2. Define an event based on that delegate
        ////Here we didn't created a method because we only wanted to create event.
        ////And also we dont need below statement if we do above thing.
        public event VideoEncodedEventHandler VideoEncoded;

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video...");
            Thread.Sleep(3000);
            OnVideoEncoded(video);
        }

        //Raise an event
        //On in OnVideoEncoded is an naming convention for raising an event.
        protected virtual void OnVideoEncoded(Video video)
        {
            if(VideoEncoded != null)
            {
                VideoEncoded(this, new VideoEventArgs() { Video = video});
            }
        }

        ////Normal way to do it but now we need to add more things to it
        ////for event. Because we want to add new service to it.
        //public void Encode(Video video)
        //{
        //    Console.WriteLine("Encoding video...");
        //    Thread.Sleep(3000);
        //}
    }
}
