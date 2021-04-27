using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._5.Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Radius();
            //Triangle();
            //Round();
            //BMI();
            //Console.WriteLine(Savings(5000,.05,10));
            //Letter();
            Console.WriteLine(EvenOrOdd());
        }

        static void Radius()
        {
            
            Console.WriteLine("Please enter a radius for a circle");
            double radius = Convert.ToInt32(Console.ReadLine());

            double diameter = radius * 2;

            double circumference = diameter * 3.14;

            double area = 3.14 * Math.Pow(radius, 2);

            Console.WriteLine($"The circumference of the circle is: {circumference}");
            Console.WriteLine($"The area of the circle is: {area}");
        }

        static void Triangle()
        {
            Console.WriteLine("Please enter a base-width for a triangle");
            double baseWidth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a height for a triangle");
            double height = Convert.ToInt32(Console.ReadLine());

            double area = (baseWidth * height) / 2;

            Console.WriteLine($"The area of the triangle is: {area}");

        }

        static void Round()
        {
            Console.WriteLine("Please enter a double.");
            double userInput = Convert.ToDouble(Console.ReadLine());
            double newValue = Math.Round(userInput);
            Console.WriteLine($"Your new value is {newValue}");
            
        }

        static void BMI()
        {
            Console.WriteLine("Please enter your weight in pounds.");
            double weight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a height in inches.");
            double height = Convert.ToInt32(Console.ReadLine());

            double bmi = (weight / Math.Pow(height, 2)) * 703;

            Console.WriteLine($"Your BMI is: {bmi}");
        }

        static double Savings(int investment, double interest, double years)
        {
            //n = times the investment is compounded, so 12 for once a month.
            int n = 12;

            //investment * (1 + Interest / compund)^
            double compound = investment * (Math.Pow(1 + (interest / n),years));

            //Console.WriteLine($"Your compound interest is {compound}");
            return compound;
        }

        public static void Letter()
        {
            string name = "Steven Jimenez";
            string street = "222 Stoober St";
            string city = "NY";

            Console.WriteLine("+---------------------------------------+");
            Console.WriteLine("|                                   ####|");
            Console.WriteLine("|                                   ####|");
            Console.WriteLine("|                                   ####|");
            Console.WriteLine("|                                       |");
            Console.WriteLine($"|                       {name}  |");
            Console.WriteLine($"|                       {street}  |");
            Console.WriteLine($"|                       {city}              |");
            Console.WriteLine("+---------------------------------------+");
            
        }

        static string EvenOrOdd()
        {
            Console.WriteLine("Please enter a number.");
           int num = Convert.ToInt32(Console.ReadLine());
           if(num % 2 == 0)
            {
                Console.WriteLine("Your numver is even.");
            }
            else
            {
                Console.WriteLine("Your numver is odd.");
            }
           return null;
        }
        
    }
}
