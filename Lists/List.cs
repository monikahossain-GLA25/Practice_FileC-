using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{ class List
    {
        public static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(19);
            numbers.Add(20);

            //i can also add array to a list
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, };
            numbers.AddRange(array);

            List<string> fruuits = new List<string>();
            fruuits.Add("Apple");
            fruuits.Add("Banana");
            fruuits.Add("Mango");
            fruuits.Add("Orange");

            Console.WriteLine("Numbers in the list:");
            foreach(var fruits in fruuits)
            {
                Console.WriteLine(fruits);
            }
            fruuits.Remove("Mango");
            fruuits.Remove("Orange");

            Console.WriteLine("Numbers in the list after removing Mango and Orange:");
            foreach (var fruits in fruuits)
            {
                Console.WriteLine(fruits);
            }
            fruuits.RemoveAt(0);
            //Console.WriteLine(fruuits.Count);
            Console.WriteLine("So The total number of fruits in the list is: " + fruuits.Count);

            Console.WriteLine("Remaining Fruits is given below : ");//remove specify index
            foreach (var fruits in fruuits)
            {
                Console.WriteLine(fruits);

                
            } 

            //now trying to concatenating lists
            List<string> vegetables = new List<string>();
            vegetables.Add("Carrot");
            vegetables.Add("Potato");
            vegetables.Add("Tomato");

            fruuits.AddRange(vegetables);
            Console.WriteLine("Combined list of fruits and vegetables:");
            foreach (string item in fruuits)
            {
                Console.WriteLine(item);
            }
            List<int> primeNumbers = new List<int>();
            primeNumbers.Add(2);
            primeNumbers.Add(3);
            primeNumbers.Add(5);
            primeNumbers.Add(7);
            primeNumbers.Add(11);

            Console.WriteLine(primeNumbers.Count);
            Console.WriteLine(primeNumbers[0]);
            Console.WriteLine(primeNumbers[1]);
            Console.WriteLine(primeNumbers[2]);
            Console.WriteLine(primeNumbers[3]);
            Console.WriteLine(primeNumbers[4]);

        }
    }
    


}
