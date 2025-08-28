namespace PaymentProcessingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Payment creditCardPayment = new CreditCardPayment(1500, DateTime.Now, "564987654", "Brence");
            creditCardPayment.ProcessPayment();

            Payment upiPayment = new UPIPayment(400, DateTime.Now, "axisbank.upi", "Axis Bank");
            upiPayment.ProcessPayment();
        }
    }
}

