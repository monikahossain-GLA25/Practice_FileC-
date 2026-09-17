using System;
using System.Collections.Generic;
using System.Text;

namespace StaticFunction
{
  public  static class config
    {
        public static string NameOfTheApplication { get; set; } = "MonikaApp";



        public static int version { get; set; } = 1;

        //public static void Main(string[] args)
        //{

        //    Console.WriteLine($"Application Name: {NameOfTheApplication}");
        //    Console.WriteLine($"Version: {version}");

        //}


    }
    public class Schedule
    {
       public class Mathclass
        {
            public const int One = 1
                , Two = 2    , Three = 3 , Four = 4, Five = 5;

            public static int Add(int a, int b)
            {
                return a + b; 
            
            }


        }
    }
    public class program
    {
        public static void Main(string[] args)
        {
            
            Console.WriteLine($"Sum of 2 and 3 is: {Schedule.Mathclass.Add(2, 3)}");
            Console.WriteLine(Schedule.Mathclass.One);

        }
    }
}
