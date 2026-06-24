using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    public class Exercise
    {
        public void PrintNumbers()
        {
            // TODO
            List<int> myNumbers = new List<int> { 1, 2, 3 };
            foreach (int numbers in myNumbers)
            {
                Console.WriteLine(numbers.ToString());
            }
        }
        public static void Main(string[] args)
        {

            Exercise obj = new Exercise();
            obj.PrintNumbers();


            List<string> colors = new List<string>
            {
                "red",
                "blue",
                "green",
                "red"
            };
            List<int> numbers = new List<int>
            {
                1,
                78,
                34,
                2,
                3,
                4,
                5,
                6,
                7,
            };
            numbers.Sort();
            Console.WriteLine("The Sorted Number is Given Below : ");

          
            foreach (int sortedNumbers in numbers)
            {
               
                Console.WriteLine(sortedNumbers.ToString());
            }

           List<int> higherequal =  numbers.FindAll(x => x >= 70);
            Console.WriteLine("The Largest Number is Given Below : ");
            foreach (int  largestNum in higherequal)
            {
                Console.Write(largestNum.ToString());
            }

          
        }
    }
}
