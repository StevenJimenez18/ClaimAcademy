using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Implementation : IFirst, ISecond
    {

        
        public int Add(int a, int b)
        {
            int c = a + b;
            return c;
        }

        public int Subtract(int a, int b)
        {
            
            int c = a - b;
            return c;
        }
    }
}
