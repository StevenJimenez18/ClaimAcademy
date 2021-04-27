using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignment
{
    class Dog : Animal
    {
        public Dog(

            string aColor, bool aIsMale, string aFood, string aHabitat
            )
        {
            color = aColor;
            isMale = aIsMale;
            food = aFood;
            habitat = aHabitat;

        }
    }
}
