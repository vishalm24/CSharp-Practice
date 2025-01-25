namespace ExceptionHandlingDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var api = new YouTubeApi();
                var videos = api.GetVideos("Vishal");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
////This is better way to disposing streamReader object by
////using statement we use that object defined inside using block
////after application it will be dispose automatically
////weather it is managed or unmanaged code.
////It's better rather than using finally block
//try
//{
//    using(var streamReader = new StreamReader(@"c:\file.zip"))
//    {
//        var content = streamReader.ReadToEnd();
//    }
//}
//catch(Exception ex)
//{
//    Console.WriteLine("Sorry, something went wrong...:(");
//}

//StreamReader streamReader = null;
//try
//{
//    streamReader = new StreamReader(@"c:\file.zip");
//    var content = streamReader.ReadToEnd();
//    throw new Exception("Oops");
//}
//catch(Exception ex){
//    Console.WriteLine("Sorry, something went wrong...:(");
//}
//finally
//{
//    if(streamReader != null)
//        streamReader.Dispose();
//}