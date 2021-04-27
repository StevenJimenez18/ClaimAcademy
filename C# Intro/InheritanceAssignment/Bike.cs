using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignment
{
    class Bike : Vehicle
    {
        public Bike(string aMake, string aModel, int aYearMade, int aSpeed)
        {
            make = aMake;
            model = aModel;
            yearMade = aYearMade;
            speed = aSpeed;
        }
        public override string Accelerate(int speed)
        {
            string currentSpeed = $"Your bike is going {speed} mph";
            return currentSpeed;
        }
    }
}
