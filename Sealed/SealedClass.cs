using System;
using System.Collections.Generic;
using System.Text;

namespace Sealed
{
    sealed class SealedClass
    {
        public int Add(int a , int b)
        {
            return a + b;
        }
    }
    public class testSelaed 
    {
        static void Main(string[] args)
        {
            SealedClass sealedClass = new SealedClass();
            Console.WriteLine(sealedClass.Add(74, 89));
        }
    }

   
}
