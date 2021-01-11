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
        public decimal Withdraw()

        //Deposit method
        public decimal Deposit()

        //Abstract method - implemented in sub classes
        public abstract decimal CalculateInterest();

        //Override of ToString - used to display information in listbox
        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }

    public class CurrentAccount : Account
    {
        //The new additional feature of Full Time Employee
        public double InterestRate = 0.03;

        //Implementation of abstract method
        public override decimal CalculateInterest()
        {
            
        }
    }

    public class SavingsAccount : Account
    {
        //Properties - this are additional to the base class properties
        public double InterestRate = 0.06;

        //Implementation of abstract method
        public override decimal CalculateInterest()
        {
            
        }
    }
}
