using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractHomeWork
{
    class Savings : Account
    {
        
        public override double AnnualInterest()
        {
            double compound = balance * (Math.Pow(1 + (interest / n), years));
            return compound;
        }
    }
}
