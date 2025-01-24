namespace DelegateDemoSecond
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VideoProcessor processor = new VideoProcessor();
            VideoFilters filter = new VideoFilters();
            Action<Video> filterHandler = filter.ApplyBrightness;
            filterHandler += filter.ApplyContrast;
            filterHandler += filter.Resize;
            filterHandler += RedEyeRemoveFilter;
            processor.Processs("Video.mp4", filterHandler);
        }
        public static void RedEyeRemoveFilter(Video video)
        {
            Console.WriteLine("Removing red eye");
        }

        //static void Main(string[] args)
        //{
        //    VideoProcessor processor = new VideoProcessor();
        //    VideoFilters filter = new VideoFilters();
        //    VideoProcessor.VideoFilterHandler filterHandler = filter.ApplyBrightness;
        //    filterHandler += filter.ApplyContrast;
        //    filterHandler += filter.Resize;
        //    filterHandler += RedEyeRemoveFilter;
        //    processor.Processs("Video.mp4", filterHandler);
        //}
        //public static void RedEyeRemoveFilter(Video video)
        //{
        //    Console.WriteLine("Removing red eye");
        //}

        ////This is creating a dependency. And this is not the way for extensible application.
        //static void Main(string[] args)
        //{
        //    VideoProcessor processor = new VideoProcessor();
        //    processor.Processs("Video.mp4");
        //}
    }
}
