using Generic;
using System;
class Program
{
    public static void Main(string[] args)
    {
        GenericClass<string> obj1 = new GenericClass<string>("Monika");
        obj1.Display();
    }
}
