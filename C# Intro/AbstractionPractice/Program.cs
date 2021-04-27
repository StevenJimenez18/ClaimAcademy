using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Dog D1 = new Dog();
            D1.Sleep();
            D1.Sound();*/


            Cat C1 = new Cat();
            C1.noise = "Meow";
            C1.Sound(C1.noise);


            Console.ReadLine();
        }
    }
}
