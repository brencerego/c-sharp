using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosNegZero
{
    public class PNZ
    {
        int num;

        public PNZ()
        {
            num = 2;

        }
        public PNZ(int num)
        {
            this.num = num;
        }
        public void check()
        {
            if (num > 0)
            {
                Console.WriteLine("Positive");
            }
            else if (num < 0)
            {
                Console.WriteLine("Negative");
            }
            else
            {
                Console.WriteLine("Zero");
            }
        }
    }
}
