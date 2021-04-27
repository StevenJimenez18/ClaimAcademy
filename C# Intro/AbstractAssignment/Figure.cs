using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAssignment
{
    abstract class Figure
    {
        public double width, height, radius;
        public float pi = 3.14f;

        public abstract double GetArea(); // Abstract method extended to child

        public abstract void Hello(); // Abstract method extended to child

        public static void Add() // Public Method Belonging to Class
        {
            int a = 10;
            int b = 20;
            int c = a + b;
            Console.WriteLine(c);
        }

    }
}
