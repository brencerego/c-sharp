namespace NumberOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter first number: ");
                double n1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter second number: ");
                double n2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter operation (+, -, *, /): ");
                string op = Console.ReadLine();

                NumberOperations calc = new NumberOperations(n1, n2, op);
                double result = calc.Calculate();

                Console.WriteLine($"Result: {result}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Use numbers only.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero.");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Calculation complete.");
            }
        }
    }
}