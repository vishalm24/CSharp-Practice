using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegatesDemo3
{
    internal class MessageService
    {
        public void OnDemandVideo(object source, VideoEventArgs e)
        {
            Console.WriteLine("Sending message..."+e.Video.Title);
        }
    }
}
