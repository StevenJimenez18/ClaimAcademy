using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionPractice
{
    class Dog : Animal
    {
        public override void Sound(string sound)
        {
            Console.WriteLine("Woof Woof");
        }
    }
}
