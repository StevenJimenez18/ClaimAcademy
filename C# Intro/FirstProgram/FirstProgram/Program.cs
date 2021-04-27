using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Please enter a whole number.");
            //int xy = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Please enter a whole number.");
            //int yz = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Please enter a whole number.");
            //int zz = Convert.ToInt32(Console.ReadLine());
            //int ab;
            //int bc;
            //ab = xy + yz;
            //bc = xy +zz;
            //Console.WriteLine("The addition of" + xy + " and " + yz + "is : " + ab);
            //Console.WriteLine("The addition of" + xy + " and " + zz + "is : " + bc);


            //string name = "Steven";
            //char lastInitial = 'J';
            //int age = 29;
            //string address = "442 stoober street, NY";

            //Console.WriteLine("My name is " + name +  " and I am" + age + "years old. I live at " + address);
            //Console.WriteLine($"My name is {name}.{lastInitial} and I am {age} years old. I live at {address}");
            //AgeCheck();
            NumberCheck(10,25,8);
        }

        static void AgeCheck()
        {
            Console.WriteLine("Enter your age");
            int age = Convert.ToInt32(Console.ReadLine());
            if ( age >= 18)
            {
                Console.WriteLine("you can drive.");

            }
            else
            {
                Console.WriteLine("Too young to drive.");

            }
        }

        static void NumberCheck(int num1, int num2, int num3)
        {
            if(num1 > num2 && num1 > num3)
            {
                Console.WriteLine($"{num1} is the greater number");
            }
            else if(num2 > num1 && num2 > num3)
            {
                Console.WriteLine($"{num2} is the greater number");
            }
            else if(num3 > num2 && num3 > num1)
            {
                Console.WriteLine($"{num3} is the greater number");
            }
        }
    }
}
