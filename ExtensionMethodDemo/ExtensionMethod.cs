namespace System
{
    //Extension method's class always should be static
    public static class ExtensionMethod
    {
        //Extension method should always be static because it's required for extending method.
        //Need to add argument ==>
        //this {method name which need to be extend} {parameter to perform operation in it}
        //i.e. this String str . In current case
        public static string Shorten(this String str, int NumberOfWords)
        {
            if(NumberOfWords < 0)
            {
                throw new ArgumentOutOfRangeException("Number of words should be greater than 0");
            }
            if (NumberOfWords == 0)
            {
                return "";
            }
            var words = str.Split(' ');
            if(words.Length <= NumberOfWords)
            {
                return str;
            }
            return string.Join(' ', words.Take(NumberOfWords));
        }
    }
}
