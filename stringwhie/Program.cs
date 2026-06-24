using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringwhie
{
    public class Program
    {
        static void Main(string[] args)
        {
            string s1 = null;

            bool b2 = String.IsNullOrWhiteSpace(s1);
            Console.WriteLine(b2);


            string s2 = "   ";
            bool b1 = String.IsNullOrWhiteSpace(s2);
            Console.WriteLine(b1);

            string s3 = ""; 
            bool b3 = String.IsNullOrWhiteSpace(s3);
            Console.WriteLine(b3);

            string s4 = " \n ";
            bool b4 = String.IsNullOrWhiteSpace(s4);
            Console.WriteLine(b4);

            string s5 = " \t";
            bool s6 = String.IsNullOrWhiteSpace(s5);
            Console.WriteLine(s6);

            string Mango = "Mango People";
            bool s7 = String.IsNullOrWhiteSpace(Mango);
            Console.WriteLine(s7);

            string s9 = "\r";
            bool b10 = String.IsNullOrWhiteSpace(s9);
            Console.WriteLine(b10); 

        }
    }
}
