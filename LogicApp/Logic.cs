using System;
using System.Collections.Generic;
using System.Text;

namespace LogicApp
{
    public class Logic
    {

        static void Main(string[] args)
        {
            bool isRainy = true;
            bool hasUmbrella = true;

            if (!isRainy && hasUmbrella)
            {
                Console.WriteLine("Must Take Your Umbrella");
            }


            //if (!isRainy || hasUmbrella)
            //{
            //    Console.WriteLine("I can go outside but i might get wet");
            //}

            Console.WriteLine("It's not raining. Enjoy your day!");
            Console.ReadKey();


            //int num1 = 6;
            //int num2 = 3;

            //bool isHigher = num1 > num2;
            //int age = 28;
            //if (age >= 18)
            //{
            //    Console.WriteLine("yOU CAN GO TO THE PARTY");
            //}
            //else
            //{
            //    Console.WriteLine("You are not allowed to go to the party");
            //}
            //if (age == 7)
            //{
            //    Console.WriteLine("You are 7 years old and not allowed to go to the party");
            //}
        }
    }
}
