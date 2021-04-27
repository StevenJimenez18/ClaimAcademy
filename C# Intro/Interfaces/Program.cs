using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car();
            c1.speed = 40;
            c1.gear = 2;
            c1.Display();

            c1.ApplyBreaks(20);
            c1.Display();
            c1.SpeedUp(30);
            c1.Display();
            

            Console.ReadLine();
        }


        static void InterfaceIntro()
        {
            Implementation i1 = new Implementation();

            Console.WriteLine("Please enter a whole number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a whole number");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(i1.Add(a, b));
            Console.WriteLine(i1.Subtract(a, b));

            Console.ReadLine();
        }
        
    }
}
