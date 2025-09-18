class Program
{
    static void Main(string[] args)
    {
        DigitSumCalculator calculator = new DigitSumCalculator();

        calculator.ReadNumber();
        calculator.CalculateAndDisplaySum();

        Console.ReadKey(); 
    }
}
