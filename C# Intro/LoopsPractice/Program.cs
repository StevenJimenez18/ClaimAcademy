using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //QuestionOne();
            //QuestionTwo();
            //QuestionThree();
            //QuestionFour();
            QuestionFive();
        }

        static void QuestionOne()
        {
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine("*****");
            }
            Console.ReadLine();
        }

        static void QuestionTwo()
        {
            string temp = "*";
            string star = "*";

            for (int i = 0; i <= 3; i++)
            {

                if (i < 1)
                {
                    Console.WriteLine(star);
                }
                else
                {
                    temp = temp + star;
                    Console.WriteLine(temp);
                }
            }
            Console.ReadLine();
        }

        static void QuestionThree()
        {
            string stars = "*****";
            int temp = 5;

            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine(stars.Substring(0, temp));
                temp--;
            }

            Console.ReadLine();
        }

        static void QuestionFour()
        {
            string myString = "1 2 3 4 5";

            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine(myString);
            }

            Console.ReadLine();
        }

        static void QuestionFive()
        {
            int myNum = 1;

            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine($"{myNum} {myNum} {myNum} {myNum}");
                myNum++;
            }
            Console.ReadLine();
        }

        static void QuestionSix()
        {
            for (int i = 5; i >= 1; i--)
            {

                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\r\n");
            }
        }


    }
}
