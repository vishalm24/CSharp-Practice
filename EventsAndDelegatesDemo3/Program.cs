namespace EventsAndDelegatesDemo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Video video = new Video() { Title = "Video1" };
            VideoEncoder encoder = new VideoEncoder();
            MailService mail = new MailService();
            MessageService message = new MessageService();
            encoder.VideoEncoded += mail.OnDemandVideo;
            encoder.VideoEncoded += message.OnDemandVideo;
            encoder.VideoEncode(video);
        }
    }
}
