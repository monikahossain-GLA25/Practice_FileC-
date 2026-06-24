using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
      public abstract class property
        {
            public abstract string role { get; set; }

            public abstract double minimumSalary { get; set; }

            public abstract double MinimumSalary { get; set; }

        }

    public class Developer : property
    {
        private string _role = "Software Developer";

        private double salary = 56000;

        private double _minimumSalary = 27000;

        public override string role {
            get => _role;
            set => _role = value;
        }
        public override double minimumSalary
        {
            get => salary;
            set => salary = value;
        }
       
       public override double MinimumSalary
        {
            get => _minimumSalary;
            set => _minimumSalary += value;
        }
    }
    public class Test
    {
        public static void Main (string[] args)
        {
            Developer deve = new Developer ();
            Console.WriteLine("The position of the company is : " + deve.role);
            Console.WriteLine("The salary of the" + " " + deve.role + " is  " + deve.minimumSalary);
            Console.WriteLine("The minimum salary of this " + deve.role + " is " + deve.MinimumSalary);


            string[] values = { null , String.Empty, "ABCDE",
                            new String(' ' , 20),
                             new String('\u2000', 10) };
           
       
         foreach (string value in values)
                Console.WriteLine(String.IsNullOrWhiteSpace(value));

        }
    }
}
