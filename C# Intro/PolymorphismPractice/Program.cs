using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog newDog = new Dog();
            newDog.speed = 30;

            Fox newFox = new Fox();
            newFox.speed = 20;

            Tiger newTiger = new Tiger();
            newTiger.speed = 45;
            //Animals();


            Console.WriteLine(MeasureSpeed(newDog.speed, newFox.speed));
            Console.WriteLine(MeasureSpeed(newDog.speed, newFox.speed, newTiger.speed));

            /*Rectangle newRectangle = new Rectangle();
            Console.WriteLine($"Area of Rectangle: {newRectangle.Area()}");

            Square newSquare = new Square();
            Console.WriteLine($"Area of Square: {newSquare.Area()}");*/



            /*Addition(1, 5);
            Addition(1, 5, 10);
            Addition(1.5, 5);
            Addition(1, 5, 10.7);*//* */

            Console.ReadLine();
        }
        static void Animals()
        {
            Dog newDog = new Dog();
            newDog.sound = "Woof woof";
            Console.WriteLine(newDog.AnimalNoise(newDog.sound));

            Fox newFox = new Fox();
            newFox.sound = "wow-wow-wow";
            Console.WriteLine(newFox.AnimalNoise(newFox.sound));
        }

        static string MeasureSpeed(int animal1, int animal2)
        {
           if(animal1 > animal2)
            {
                return "The dog is faster.";
            }
            else
            {
                return "The fox is faster.";
            }
        }

        static string MeasureSpeed(int animal1, int animal2, int animal3)
        {
            if (animal1 > animal2 && animal1 > animal3)
            {
                return "The dog is faster.";
            }
            else if (animal2 > animal1 && animal2 > animal3)
            {
                return "The fox is faster.";
            }
            else
            {
                return "The Tiger is faster";
            }


        }





        public static void Addition( int a, int b)
        {
            int c = a + b;
            Console.WriteLine(c);
        }

        public static void Addition(int a, int b, int c)
        {
            int d = a + b + c;
            Console.WriteLine(d);
        }
        public static void Addition(double a, double b)
        {
            double d = a + b;
            Console.WriteLine(d);
        }
        public static void Addition(double a, double b, double c)
        {
            double d = a + b + c;
            Console.WriteLine(d);
        }


    }
}

