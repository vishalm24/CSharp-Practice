namespace EventsAndDelegatesDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Photo photo = new Photo() { Title = "vishal" };
            PhotoEncoder encoder = new PhotoEncoder();
            Mail mail = new Mail();
            Message message = new Message();
            encoder.PhotoEncoded += mail.OnPhotoEncoded;
            encoder.PhotoEncoded += message.OnPhotoEncoded;
            encoder.Encoder(photo);
        }
    }
}
