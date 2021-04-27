using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Car : IVehicle
    {
        public int speed, gear;

        public void ApplyBreaks(int decrement)
        {

            speed -= (decrement * 2);
            if (speed > 20)
            {
                ChangeGear(-3);
            }
            else if (speed > 40)
            {
                ChangeGear(-2);
            }
            else if (speed > 60)
            {
                ChangeGear(-1);
            }
            else
            {
                ChangeGear(-1);
            }
        }

        public void ChangeGear(int newGear)
        {
            gear = gear + newGear;
        }

        public void SpeedUp(int increment)
        {
            speed += (increment * 2);
            if(speed >= 20)
            {
                ChangeGear(1);
            }
            else if(speed >= 40)
            {
                ChangeGear(2);
            }
            else if (speed >= 60)
            {
                ChangeGear(3);
            }
        }

        public void Display()
        {
            Console.WriteLine($"Speed: {speed}, Gear: {gear}");
        }

       
    }
}
