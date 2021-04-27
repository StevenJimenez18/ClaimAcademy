using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Savings savingsAccount = new Savings();
            savingsAccount.balance = 1000;

            Console.WriteLine($"Your current balance is: {savingsAccount.ViewBalance()}");
            Console.WriteLine($"Your account balance is now: {savingsAccount.Deposit(100)}");
            Console.WriteLine($"Your account balance is now: {savingsAccount.Withdraw(200)}");
            Console.WriteLine($"Your yearly interest is: {savingsAccount.AnnualInterest()}");

            Console.ReadLine();
        }
    }
}
