using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareOfNumbers
{
    public class Square
    {
        int number;
        int square;
        public Square()
        {
            number = 2;
        }
        public Square(int number)
        {
            this.number = number;
        }
        public void CalculateSquare()
        {
            square = number * number;
        }
        public void display()
        {
            Console.WriteLine("The square of {0} is {1}", number, square);
        }
    }
}

