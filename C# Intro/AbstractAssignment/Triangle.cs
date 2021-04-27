using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAssignment
{
    class Triangle : Figure
    {
        public override double GetArea()
        {
            return .5 * width * height;
        }

        public override void Hello()
        {
            throw new NotImplementedException();
        }
    }
}
