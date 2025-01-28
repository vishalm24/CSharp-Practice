using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegatesDemo2
{
    public class PhotoEventArgs: EventArgs
    {
        public Photo Photo { get; set; }
    }
    internal class PhotoEncoder
    {
        //public delegate void PhotoEncoderEventHandler(object source, PhotoEventArgs args);
        //public event PhotoEncoderEventHandler PhotoEncoded;
        public event EventHandler<PhotoEventArgs> PhotoEncoded;
        public void Encoder(Photo photo)
        {
            Console.WriteLine("Encoding photo has ben started...");
            Thread.Sleep(3000);
            OnPhotoEncoded(photo);
        }
        protected virtual void OnPhotoEncoded(Photo photo)
        {
            if(PhotoEncoded != null)
            {
                PhotoEncoded(this, new PhotoEventArgs() { Photo = photo });
            }
        }
    }
}
