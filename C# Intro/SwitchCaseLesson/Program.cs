using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace SwitchCaseLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            //DaysOfWeek1();
            DaysOfWeek2();
        }

        static void DaysOfWeek1()
        {
            Console.WriteLine("Please enter a number from 1 to 7");

            int dayOfTheWeek = Convert.ToInt32(Console.ReadLine());
            
            switch (dayOfTheWeek)
            {
                case 1:
                    Console.WriteLine("Today is sunday.");
                    break;
                case 2:
                    Console.WriteLine("Today is Monday.");
                    break;
                case 3:
                    Console.WriteLine("Today is Tuesday.");
                    break;
                case 4:
                    Console.WriteLine("Today is Wednesday.");
                    break;
                case 5:
                    Console.WriteLine("Today is Thursday.");
                    break;
                case 6:
                    Console.WriteLine("Today is Friday");
                    break;
                case 7:
                    Console.WriteLine("Today is Saturday.");
                    break;
                default:
                    Console.WriteLine("Unkown Value");
                    break;
            }
        }

        public static void DaysOfWeek2()
        {
            Console.WriteLine("Please enter a day of the week.");

            string dayOfTheWeek = (Console.ReadLine());
            dayOfTheWeek = dayOfTheWeek.ToUpper();

            switch (dayOfTheWeek)
            {
                case  "SUNDAY":
                    Console.WriteLine("First day of the week.");
                    break;

                case "MONDAY":
                    Console.WriteLine("Second day of the week.");
                    break;

                case "TUESDAY":
                    Console.WriteLine("Third day of the week.");
                    break;

                case "WEDNESDAY":
                    Console.WriteLine("Fourth day of the week.");
                    break;

                case "THURSDAY":
                    Console.WriteLine("Fifth day of the week.");
                    break;

                case "FRIDAY":
                    Console.WriteLine("Sixth day of the week.");
                    break;

                case "SATURDAY":
                    Console.WriteLine("Seventh day of the week.");
                    break;

                default:
                    Console.WriteLine("Unkown Value");
                    break;
            }
        }
    }
}
