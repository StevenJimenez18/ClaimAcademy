using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAssignment
{

    class Circle : Figure
    {
        public override double GetArea()
        {
            return pi * Math.Pow(radius, 2);
        }

        public override void Hello()
        {
            throw new NotImplementedException();
        }
    }
}
