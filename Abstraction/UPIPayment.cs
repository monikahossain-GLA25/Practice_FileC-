using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    public class UPIPayment : Payment
    {
        public override void ProcessPayment(double amount)
        {
            Console.WriteLine("Process of Upi payment is .....");
            Console.WriteLine("The amount is transferred " + " " + amount);
        }
    }
}
