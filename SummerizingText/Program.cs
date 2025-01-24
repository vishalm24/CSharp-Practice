namespace SummerizingText
{
    //This is example of summarizing test for 20 length of words:
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence = "This is going to be a very long long long long long long text";
            string summary = SummarizeText(sentence);
            Console.WriteLine(summary);
        }
        static string SummarizeText(string sentence)
        {
            if (sentence.Length < 20) return sentence;
            var input = sentence.Split(" ");
            int length = 0;
            var summary = new List<string>();
            foreach (var item in input)
            {
                length += item.Length + 1;
                if(length > 20)
                break;
                summary.Add(item);
            }
            var output = String.Join(" ", summary)+"...";//adds words but in between adding string " "
            return output;
        }
    }
}
