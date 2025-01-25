using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyLoadingDemo
{
    internal class PersonalLoanLazy
    {
        public string AccountNumber { get; set; }
        public string AccountHolderName { get; set; }
        public Loan LoanDetail { get; set; }
        public PersonalLoanLazy(String _AccountNumber)
        {
            this.AccountNumber = _AccountNumber;
            this.AccountHolderName = "Vishal";
        }
    }
}
