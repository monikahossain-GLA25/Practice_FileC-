using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace interfacepolymor
{
    public interface IPaymentProcess
    {
    void ProcessPayment(decimal amount);
    
    }
    public class CreditCardProcessor : IPaymentProcess
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing credit card payment of {amount:C}");
        }
    }

    public class PaypalCardProcessor : IPaymentProcess
    {
               public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing PayPal payment of {amount:C}");
        }

    }

    public class  PaymentService
    {
        private readonly IPaymentProcess _paymentProcessor;

        public PaymentService(IPaymentProcess paymentProcess)
        {
          _paymentProcessor = paymentProcess;

        }

      public  void ProcessPayment(decimal amount)
        {
            _paymentProcessor.ProcessPayment(amount);
        }   


    }
    public class Team
    {
        public string teamName;
        public int noOfPlayers;

        public Team(string TeamName, int NoOfPlayers)
        {
            this.teamName = TeamName;
            this.noOfPlayers = NoOfPlayers;
        }
        public int AddPlayers(int players)
        {
            
            return noOfPlayers + players;
        }
        
        public int RemovePlayers(int players)
        {
            return noOfPlayers - players;
        } 
    }
    public class SubTeam : Team
    {
        public SubTeam(string TeamName, int NoOfPlayers) : base(TeamName, NoOfPlayers)
        {
        }
        public string ChangeTeamName(string teamName) { 
            this.teamName = teamName;
            return this.teamName;
        }
    }
    internal class program
    {
        static void Main(string[] args)
        {

            //Polymorphism allows us to use the same interface to process payments through different payment processors (CreditCardProcessor and PaypalCardProcessor) without changing the PaymentService class.
            IPaymentProcess creditCardProcessor = new CreditCardProcessor();
            PaymentService paymentService1 = new PaymentService(creditCardProcessor);
            paymentService1.ProcessPayment(100.00m);

            IPaymentProcess paypalProcessor = new PaypalCardProcessor();
            paymentService1 = new PaymentService(paypalProcessor);
            paymentService1.ProcessPayment(200.00m);
        }
    }
}
