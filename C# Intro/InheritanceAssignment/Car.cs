using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignment
{
    class Car : Vehicle
    {
        
        public Car(string aMake, string aModel, int aYearMade, int aSpeed)
        {
            make = aMake;
            model = aModel;
            yearMade = aYearMade;
            speed = aSpeed;

        }

        public override string Accelerate(int speed)
        {
            string currentSpeed = $"Your car is going {speed} mph";
            return currentSpeed;
        }
    }
}
