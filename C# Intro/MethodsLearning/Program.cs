using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            Add(10, 28);
            Console.WriteLine("Third " + Mul(20, 40));
            Console.WriteLine(Addthree());
        }

        public static int Mul(int a, int b)
        {
            int c = a * b;
            Console.WriteLine("Second.");
            return c;
        }

        public static void Add(int a, int b)
        {
            int c = a + b;
            Console.WriteLine("First");
        }

        public static double Addthree()
        {
            double num1 = 10.5;
            double num2 = 20.10;
            double num3 = 25.10;

            double sum = num1 + num2 + num3;

            return sum;
        }
    }
}
