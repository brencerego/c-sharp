namespace ReverseOfNumber
{
    internal class Program
    {
         static void Main(string[] args)
            {
            Console.WriteLine("Enter a number to find the reverse:");
               int num = Convert.ToInt32(Console.ReadLine());
               Reverse r = new Reverse(num);
               r.process();
               r.display();
            }
        }
    }