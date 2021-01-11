﻿using System;
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
        public DateTime InterestDate { get; set; }

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
        //Interest rate property for current accounts set at 3%
        public double InterestRate = 0.03;

        //Implementation of abstract method
        public override decimal CalculateInterest()
        {
            decimal Interest = Balance * (decimal)InterestRate;
            InterestDate = DateTime.Now;
        }
    }

    public class SavingsAccount : Account
    {
        //Interest rate property for current accounts set at 6%
        public double InterestRate = 0.06;

        //Implementation of abstract method
        public override decimal CalculateInterest()
        {
            decimal Interest = Balance * (decimal)InterestRate;
            InterestDate = DateTime.Now;
        }
    }
}
