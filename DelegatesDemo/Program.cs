namespace DelegatesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Using Action<> instead of handler
            ////Multicast delegate demo
            //var processor = new PhotoProcessor();
            //var filter = new PhotoFilters();
            ////Changed PhotoProcessor.PhotoFilterHandler to Action<Photo>
            //Action<Photo> filterHandler = filter.ApplyBrightness;
            //filterHandler += filter.ApplyContrast;
            //filterHandler += RemoveRedEyeFilter;
            //processor.Process("photo.jpg", filterHandler);

            //Multicast delegate demo
            var processor = new PhotoProcessor();
            //PhotoFilters instance
            var filter = new PhotoFilters();
            //Adding delegate handler and apending methods as a parameters to handler.
            PhotoProcessor.PhotoFilterHandler filterHandler = filter.ApplyBrightness;
            //For multicasting delegate we just has to add another method as parameter.
            filterHandler += filter.ApplyContrast;
            //We can add other methods to delegate as parameter but
            //It must have same return value and signature.
            filterHandler += RemoveRedEyeFilter;
            //Here we just pass variable path string and delegate handler to method in
            //which we have all methods which earplier we passed as paramters.
            processor.Process("photo.jpg", filterHandler);
        }
        static void RemoveRedEyeFilter(Photo photo)
        {
            Console.WriteLine("Apply RemoveRedEye");
        }
        //We added new method but it must have same signature and return value.


        ////Privious methods before using delegate
        //static void Main(string[] args)
        //{
        //    var processor = new PhotoProcessor();
        //    processor.Process("photo.jpg");
        //}
    }
}
