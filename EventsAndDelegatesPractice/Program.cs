namespace EventsAndDelegatesPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { Title = "Videoname"};
            var videoEncoder = new VideoEncoder();
            var mailServices = new MailServices();
            var messageServices = new MessageServices();
            videoEncoder.VideoEncoded += mailServices.OnVideoEncoded;
            videoEncoder.VideoEncoded += messageServices.OnVideoEncoded;
            videoEncoder.Enocode(video);
        }
    }
}
