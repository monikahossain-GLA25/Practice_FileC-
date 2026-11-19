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
            bool hasUmbrella = false;

            if (isRainy && !hasUmbrella)
            {
                Console.WriteLine("Must Take Your Umbrella");
            }
            int age = 25;
            if(age >= 10 && age <=28)
            {
                Console.WriteLine("They are Allowed to Party.");
            }


            bool isStudent = false;
            bool isMember = false;

            if(isStudent || !isMember)
            {
                Console.WriteLine("They Belong to Same Family");
            }
            int agee = 13;

            //if (agee >= 25 || agee <= 30)
            //{
            //    Console.WriteLine("OutSide age is not possible");
            //}
            if(agee >= 18)
            {
                Console.WriteLine("Go party in the club");
            }
            else if (agee > 6)
            {
                Console.WriteLine("Need to go to school");
            }
            else {
                Console.WriteLine("Go Party on Kindergerten.");
            }

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
