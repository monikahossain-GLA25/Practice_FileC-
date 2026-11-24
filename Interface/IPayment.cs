using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public interface IPayment
    {
         void Pay(decimal amount);
    }
    public class CashPayment : IPayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid {amount} in cash.");
        }
    }
   public class CardPayment : IPayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid {amount} using card.");
        }
    }
    public class MobileBanking : IPayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid {amount} using mobile banking.");
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            IPayment cashPayment = new CashPayment();
            cashPayment.Pay(100);
            IPayment cardPayment = new CardPayment();
            cardPayment.Pay(200);
            IPayment mobileBanking = new MobileBanking();
            mobileBanking.Pay(300);
        }
    }
}
