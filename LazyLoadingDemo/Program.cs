namespace LazyLoadingDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //This is code from c-sharpcorner.com
            //https://www.c-sharpcorner.com/UploadFile/dacca2/implement-lazy-loading-in-C-Sharp-using-lazyt-class/
            //Lazy loading
            PersonalLoanLazy PLoan = new PersonalLoanLazy("123456");
            //Loan detail started to load
            PLoan.LoanDetail = new Loan("123456");
            Console.WriteLine(PLoan.LoanDetail.AccountNumber);
            Console.WriteLine(PLoan.LoanDetail.IsLoanApproved);
            Console.WriteLine(PLoan.LoanDetail.LoanAmount);
            Console.ReadLine();
            ////Not Lazy Loading
            //PersonalLoan PLoan = new PersonalLoan("123456");
            //Console.ReadLine();
        }
    }
}
