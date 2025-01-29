using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegatesDemo3
{
    internal class MailService
    {
        public void OnDemandVideo(object source, VideoEventArgs e)
        {
            Console.WriteLine("Sendding mail..."+e.Video.Title);
        }
    }
}
