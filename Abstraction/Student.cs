using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    abstract class Student
    {


        protected string name;

        public abstract string Name_2 {  get; }





        public string Name { get; set; }

        public int Age { get; set; }

        public abstract void DisplayInfo();

        //non abstract method
        public void call()
        {
            Console.WriteLine("This is a non abstract method");
        }

    }
}
