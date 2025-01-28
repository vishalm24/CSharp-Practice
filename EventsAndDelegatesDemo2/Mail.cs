using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegatesDemo2
{
    internal class Mail
    {
        public void OnPhotoEncoded(object source, PhotoEventArgs ar)
        {
            Console.WriteLine("Sending photo through mail..." + ar.Photo.Title);
        }
    }
}
