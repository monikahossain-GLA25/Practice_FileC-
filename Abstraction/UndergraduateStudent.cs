using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
     class UndergraduateStudent : Student
    {
        public string Major { get; set; }

        public override string Name_2 => throw new NotImplementedException();

        public override void DisplayInfo()
        {
            Console.WriteLine("This is a implementation of a abstract class");
            Console.WriteLine("Name of the Undergrad Registred Student" +" " + Name);
            Console.WriteLine("Age of the Undergrad Registred Student" + " " + Age);
            Console.WriteLine("Major Course Taken" + " " + Major);
        }
    }
}
