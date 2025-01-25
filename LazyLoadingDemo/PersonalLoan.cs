using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyLoadingDemo
{
    internal class PersonalLoan
    {
        public string AccountNumber { get; set; }
        public string AccountHolderName { get; set; }
        public Loan LoanDetail { get; set; }
        public PersonalLoan(String _AccountNumber)
        {
            this.AccountNumber = _AccountNumber;
            this.AccountHolderName = "Vishal";
            this.LoanDetail =new Loan(this.AccountNumber);
        }
    }
}
