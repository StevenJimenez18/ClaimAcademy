using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionPractice
{
    abstract class Animal
    {
        public string noise;

        public void Sleep()
        {
            Console.WriteLine("zzzzzz");
        }

        public abstract void Sound(string sound);
    }
}
