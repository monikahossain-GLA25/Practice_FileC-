using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticFunction
{
    public class StaticConstructor
    {
        class SomeClass
        {
            public static int XBert { get; set;  }
            public static int YLLM { get; set; }


            static SomeClass()
            {
                YLLM = 1;
                XBert = 42;
                Console.WriteLine("Static constructor called.");
                
            }
            static void Main(string[] args)
            {
                Console.WriteLine(SomeClass.XBert);
                Console.WriteLine(SomeClass.YLLM);
                
            }
        }
    }
}
