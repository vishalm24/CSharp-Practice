namespace EventsAndDelegatesPractice
{
    public class MailServices
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("MailService: Sending an Email..."+e.Video.Title);
        }
    }
}
