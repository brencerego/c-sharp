namespace PosNegZero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int num = Convert.ToInt32(Console.ReadLine());
            PNZ pnz = new PNZ(num);
            pnz.check();
        }
    }
}
