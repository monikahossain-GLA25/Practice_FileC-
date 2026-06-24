 using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphisom
{
     class Employee : Student
    {
        public string Name { get; set; }
        public override void DisplayInfo(string name)
        {
            base.DisplayInfo();
            Console.WriteLine(Name);
        }
    }
}
