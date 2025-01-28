using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{
    internal class PhotoProcessor
    {
        ////Using inbuilt Action<> delegate
        //public void Process(string path, Action<Photo> filterHandler)
        //    //Here we changed the handler to Action
        //{
        //    var photo = Photo.Load(path);
        //    filterHandler(photo);
        //    photo.Save();
        //}

        public delegate void PhotoFilterHandler(Photo photo);
        //Defining delegate
        public void Process(string path, PhotoFilterHandler filterHandler)
        //Here we added PhotoFilterHandler delegate as parameter
        {
            //This is just a instance of Photot class with constructor
            var photo = Photo.Load(path);
            //Here we use to invoke merthods but right now here we are
            //only passing variable photo to delegate
            filterHandler(photo);
            photo.Save();
        }

        ////This was normal method
        //public void Process(string path)
        //{
        //    var photo = Photo.Load(path);
        //    var filters = new PhotoFilters();
        //    filters.ApplyBrightness(photo);
        //    filters.ApplyContrast(photo);
        //    filters.Resize(photo);
        //    photo.Save();
        //}
    }
}
