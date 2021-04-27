using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractHomeWork
{
    abstract class Account
    {
        public double balance;
        public double interest = 10;
        public double years = 1;
        public double n = 12;

        public double Deposit(double num)
        {
            balance += num;
            return balance;
        }

        public double Withdraw(double num)
        {
            balance -= num;
            return balance;
        }

        public double ViewBalance()
        {
            return balance;
        }

        public abstract double AnnualInterest();
    }
}
