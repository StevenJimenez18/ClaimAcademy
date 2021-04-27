using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAssignment
{
    class Rectangle : Figure
    {
        public Rectangle(double aWidth, double aHeight)
        {
            width = aWidth;
            height = aHeight;
        }

        public override double GetArea() //Abstract method from parent
        {
            return width * height;
        }

        public override void Hello() //Abstract method from parent
        {
            Console.WriteLine("Hello C#");
        }

        public static void Sum() // Public Method Belonging to Class
        {
            Console.WriteLine("Sum Method");
        }

    }
}
