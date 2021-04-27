using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vehicles();
            Animals();

            Console.ReadLine();
        }

        static void Vehicles()
        {
            Car newCar = new Car("Lexus", "IS250", 2010, 65);
            Console.WriteLine(newCar.Accelerate(Car.speed));
            Console.WriteLine(newCar.Breaks(Car.speed));

            Bike newBike = new Bike("Kawasaki", "Ninja", 2012, 90);

            Console.WriteLine(newBike.Accelerate(Bike.speed));
        }

        

        static void Animals()
        {
            Elephant newElephant = new Elephant("Grey", false, "Peanuts", "Savannah");
            Console.WriteLine(newElephant.FavoriteFood(newElephant.food));

            Dog newDog = new Dog("Brown", false, "Treats", "comfy couch");
            Console.WriteLine(newDog.Habitat(newDog.habitat));
        }
    }
}
