using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Program
    {
        public string name;
        public Program(string n)
        {
            name = n;
        }
        public void say()
        {
            Console.WriteLine("My Name is " + name);
        }

        static void AddNumber(int x, int y)
            {
                int sum = x + y;
                Console.WriteLine(sum);
            }
        //user define function
        public void NewNumbers()
        {
            int x = 12;
            decimal y = 89.9M;
            int sum = (int)(x + y);//i do explicit

            Console.WriteLine("The value of the sum is : " + sum);
        }
        public void MultipleNumber(int a, int b)
        {
            int s = a * b;
            Console.WriteLine(s);
        }
        //create function as arguments but no return type  
        static void Main(string[] args)
        {
            AddNumber(1, 2);
            Program obj = new Program("chinky");
            obj.NewNumbers();

            obj.MultipleNumber(75, 34);
            obj.say();
            

        }

           
        
        
    }
}
