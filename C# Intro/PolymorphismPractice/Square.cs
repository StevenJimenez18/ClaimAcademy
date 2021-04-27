using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismPractice
{
    class Square : Figure
    {
        public double length { get; set; }

        public Square()
        {
            length = 10;
        }

        public override double Area()
        {
            return Math.Pow(length, 2);
        }

    }
}
