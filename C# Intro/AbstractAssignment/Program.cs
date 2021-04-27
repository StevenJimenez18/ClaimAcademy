using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
           /* Rectangle r1 = new Rectangle(12.36, 123.65);
            double result = r1.GetArea();
            r1.Hello();
            Console.WriteLine(result);
            Figure.Add();

            Rectangle.Sum();*/


            Triangle t1 = new Triangle();
            t1.height = 4.5;
            t1.width = 6.9;
            Console.WriteLine($"Area of triangle is: {t1.GetArea()}");


            Circle c1 = new Circle();
            c1.radius = 15.6;
            Console.WriteLine($"Area of circle is: {c1.GetArea()}");




            Console.ReadLine();

        }
    }
}
