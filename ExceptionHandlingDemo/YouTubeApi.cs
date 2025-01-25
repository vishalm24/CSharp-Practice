using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingDemo
{
    internal class YouTubeApi
    {
        public List<Video> GetVideos(string user)
        {
            try
            {
                //Access youTube web services
                //Read the data
                //Create a list of Video objects
                throw new Exception("Oops some low level YouTube error");
            }
            catch(Exception ex)
            {
                //log
                throw new YouTubeException("Could not fetch the videos from youtube", ex);
            }
        }
    }
}
