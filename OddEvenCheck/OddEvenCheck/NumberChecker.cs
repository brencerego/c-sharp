using System;

namespace OddEvenCheck
{
    class NumberChecker
    {
        private int number;

        public void ReadNumber()
        {
            Console.Write("Enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());
        }
        public void DisplayResult()
        {
            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} is Even.");
            }
            else
            {
                Console.WriteLine($"{number} is Odd.");
            }
        }
    }
}
