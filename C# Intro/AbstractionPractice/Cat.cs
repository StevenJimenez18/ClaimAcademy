using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionPractice
{
    class Cat : Animal
    {
        public override void Sound(string sound)
        {
            Console.WriteLine($"This animal makes a {sound} noise ");
        }
    }
}
