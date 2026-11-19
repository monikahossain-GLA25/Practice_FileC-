using System;
using System.Collections.Generic;
using System.Text;

namespace Generic
{
    class GenericClass<T>
    {
        private T data;

        public GenericClass(T value)
        {
            this.data = value;
        }
            
        public void Display()
        {
            Console.WriteLine("Value " + data);
        }
    }
}
