using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismPractice
{
    class Rectangle : Figure
    {
        public double weight { get; set; }
        public double height { get; set; }

        public Rectangle()
        {
            weight = 15;
            height = 10;
        }

        public override double Area()
        {
            return weight * height;
        }
    }
}
