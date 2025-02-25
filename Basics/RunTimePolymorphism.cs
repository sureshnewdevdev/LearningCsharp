using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    public class Payment
    {
        public virtual void MakePayment(double amount)
        {
            Console.WriteLine($"Processing a generic payment of ${amount}.");
        }
    }

    class CreditCard : Payment
    {
        public override void MakePayment(double amount)
        {
            Console.WriteLine($"Processing a generic payment of ${amount}. in the child this method is over ridden");
        }
    }

    public class RunTimePolymorphism
    {
        public static void Main(string[] args)
        {
            // Before Runtime polymorphism

            // CreditCard creditCard = new CreditCard(); // Note : Data hidded from Parent class 
            //creditCard.MakePayment(10);

            //Payment payment = new CreditCard();
            // payment.MakePayment(33); // this will go to parent method

            // After Runtime polymorphism implemented

            CreditCard creditCard = new CreditCard();  
            creditCard.MakePayment(10);

            Payment payment = new CreditCard();
            payment.MakePayment(33);

            payment = new Payment();
            payment.MakePayment(33);


        }
    }
}
