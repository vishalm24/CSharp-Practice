
namespace EventsAndDelegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { Title = "Video  1"};
            var videoEncoder = new VideoEncoder();//publisher
            var mailService = new MailService();//subscriber
            var messageService = new MessageService();//subscriber
            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;
            videoEncoder.Encode(video);
        }

        //Just for encoding video but we can't add any other method to
        //VideoEncoder for other purposes.
        //If we do then it will create dependency and that may will raise
        //error or changing other methods in VideoEncoder.
        //Solution is that we have to use event. For that we are going
        //to create delegate and event handler in VideoEncoder class.
        //static void Main(string[] args)
        //{
        //    var video = new Video() { Title = "Title 1" };
        //    var videoEncoder = new VideoEncoder();
        //    videoEncoder.Encode(video);
        //}
    }
}
