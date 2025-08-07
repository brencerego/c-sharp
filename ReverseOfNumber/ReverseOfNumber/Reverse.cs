using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseOfNumber
{
    public class Reverse
    {
        int num;
        int rev = 0;
        int temp;
        public Reverse(int num)
        {
            this.num = num;
        }
        public void process()
        {
            while (num > 0)
            {
                temp = num % 10;
                num /= 10;
                rev = rev * 10 + temp;
            }

        }
        public void display()
        {
            Console.WriteLine($"The Reversed Number is {rev}");
        }
    }
}


