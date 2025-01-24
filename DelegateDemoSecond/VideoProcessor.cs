using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemoSecond
{
    internal class VideoProcessor
    {
        //public delegate void Action<video>(Video video);
        public void Processs(string path, Action<Video> filterHandler)
        {
            var video = Video.Load(path);
            filterHandler(video);
            video.Save();
        }

        //public delegate void VideoFilterHandler(Video video);
        //public void Processs(string path, VideoFilterHandler filterHandler)
        //{
        //    var video = Video.Load(path);
        //    filterHandler(video);
        //    video.Save();
        //}
    }
}
