namespace GreetPerson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Name:");
            String name = Console.ReadLine();
            Greet g = new Greet(name);
            g.greet();
        }
    }
}
