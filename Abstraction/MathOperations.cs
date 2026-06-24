using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    public abstract class MathOperations
    {

        

        //This is also a abstract method 
        public abstract double Evaluate(double x);
        //this is a NON ABSTRACT METHOD
        public int Add(int x, int y)
        {
            return x + y; 
        }

        //This is a Abstract Method
        public abstract int Subtract(int x, int y);
    }

    public class SimpleMath() : MathOperations
    {
        public override double Evaluate(double x)
        {
            throw new NotImplementedException();
        }

        public override int Subtract(int x, int y)
        {
            return (x - y) / (x - y);

        }
    }
    public class runProgram()
    {
        static void Main(string[] args)
        {
            
            SimpleMath objSimpleMath = new SimpleMath();
            Console.WriteLine(objSimpleMath.Subtract(190, 9));
        }
    }
}
