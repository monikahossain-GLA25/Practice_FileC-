using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    public abstract class Payment
    {
        public abstract void ProcessPayment(double amount);

        public void PrintDetails(double amount)
        {
            Console.WriteLine("Total Amount is : " + " " + amount);
            Console.WriteLine("TTransaction Date: " + " " + DateTime.Now);
        }

    }
}
