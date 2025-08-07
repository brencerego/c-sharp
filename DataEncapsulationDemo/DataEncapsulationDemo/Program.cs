using DataEncapsulationDemo;


    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "Brence";
            person.Age = 18;
            Console.WriteLine($"The name is {person.Name} and age is {person.Age}");

        }
    }

