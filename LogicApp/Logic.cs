using System;
using System.Collections.Generic;
using System.Text;

namespace LogicApp
{
    public class Logic
    {

        static void Main(string[] args)
        {
            bool isRainy = false;
            bool hasUmbrella = true;

            if (isRainy)
            {
                Console.WriteLine("It's raining. Don't forget to take an umbrella!");
            }
            Console.WriteLine("It's not raining. Enjoy your day!");
            Console.ReadKey();
        }
    }
}
