using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_January_Exam
{
    public abstract class Account
    {
        //Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Balance { get; set; }
        public decimal InterestDate { get; set; }

        //Withdraw method
        public abstract decimal Withdraw();

        //Deposit method
        public abstract decimal Deposit();

        //Abstract method - implemented in sub classes
        public abstract decimal CalculateMonthlyPay();

        //Override of ToString - used to display information in listbox
        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
