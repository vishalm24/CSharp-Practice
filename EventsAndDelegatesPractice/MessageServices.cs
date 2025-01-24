namespace EventsAndDelegatesPractice
{
    public class MessageServices
    {
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine("MessageService: Sending a Message..."+args.Video.Title);
        }
    }
}
