using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignment
{
    class Vehicle
    {
        public string make;
        public string model;
        public int yearMade;
        public static int speed;

        public string Breaks(int speed)
        {
            int brake = 25;
            int breakPower = speed - brake;
            string breaks = $"Your vehicle hit the breaks and reduced to {breakPower} .";
            return breaks;
        }

        public virtual string Accelerate(int speed)
        {
            string currentSpeed = $"Your vehicle is going {speed} mph";
            return currentSpeed;
        }

    }
}
