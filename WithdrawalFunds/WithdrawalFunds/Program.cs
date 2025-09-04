namespace WithdrawalFunds
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount(5000);

            Console.Write("Enter withdrawal amount: ");
            decimal amount = decimal.Parse(Console.ReadLine());

            try
            {
                account.Withdraw(amount);
                Console.WriteLine("Withdrawal successful.");
                Console.WriteLine("New Balance: " + account.Balance);
            }
            catch (InsufficientFundsException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
    }
}