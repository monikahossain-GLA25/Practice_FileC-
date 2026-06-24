using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    abstract class Shape
    {

        public abstract double Area();
    }

    class Rectangle : Shape
    {

        public double Length { get; set; }

        public double width { get; set; }

        public Rectangle(double l , double r)
        {
            this.Length = l;
            this.width = r;
        }

        
        public override double Area()
        {
            return Length * width;
        }
    }
     class Text
    {
        public static void Main(string[] args)
        {
            Rectangle obj = new Rectangle(890.88, 283);
            Console.WriteLine(obj.Area());  
        }
    }
}
