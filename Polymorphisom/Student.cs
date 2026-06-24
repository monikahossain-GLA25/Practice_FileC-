using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphisom
{
     class Student
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name} , Age : {Age}");
        }

        public virtual void DisplayInfo(string name)
        {
            Console.WriteLine($"Name: {Name} , Age : {Age}");
        }
    }
}
