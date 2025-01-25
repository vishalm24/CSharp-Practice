using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyLoadingDemo
{
    internal class Loan
    {
        public string AccountNumber { get; set; }
        public float LoanAmount { get; set; }
        public bool IsLoanApproved { get; set; }
        public Loan(string _AccountNumber)
        {
            Console.WriteLine("Loan loading started");
            this.AccountNumber = _AccountNumber;
            this.LoanAmount = 1000;
            this.IsLoanApproved = true;
            Console.WriteLine("Lazy loading started");
        }
    }
}
