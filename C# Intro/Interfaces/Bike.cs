using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Bike : IVehicle
    {
        public int speed, gear;

        public void ApplyBreaks(int decrement)
        {
            
            speed -= decrement;
        }

        public void ChangeGear(int  newGear)
        {
            gear = newGear;
        }

        public void SpeedUp(int increment)
        {
            speed += increment;
        }

        public void Display()
        {
            Console.WriteLine($"Speed: {speed}, Gear: {gear}");
        }
    }
}
