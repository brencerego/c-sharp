using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentProcessingSystem
{

    public class Payment
    {
        public double Amount { get; set; }
        public DateTime Date { get; set; }

        public Payment(double amount, DateTime date)
        {
            Amount = amount;
            Date = date;
        }

        public virtual void ProcessPayment()
        {
            Console.WriteLine($"Processing payment of {Amount} on {Date}");
        }
    }

    public class CreditCardPayment : Payment
    {
        public string CardNumber { get; set; }
        public string CardHolderName { get; set; }

        public CreditCardPayment(double amount, DateTime date, string cardNumber, string cardHolderName)
            : base(amount, date)
        {
            CardNumber = cardNumber;
            CardHolderName = cardHolderName;
        }

        public override void ProcessPayment()
        {
            Console.WriteLine($"Processing Credit Card Payment of {Amount} for {CardHolderName} using card {CardNumber.Substring(0, 4)}****");
        }
    }

    public class UPIPayment : Payment
    {
        public string UpiId { get; set; }
        public string BankName { get; set; }

        public UPIPayment(double amount, DateTime date, string upiId, string bankName)
            : base(amount, date)
        {
            UpiId = upiId;
            BankName = bankName;
        }

        public override void ProcessPayment()
        {
            Console.WriteLine($"Processing UPI Payment of {Amount} from {UpiId} through {BankName}");
        }
    }
}
