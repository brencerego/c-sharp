using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetPerson
{
    public class Greet
    {
        string name;
        public Greet()
        {
            name = "John Doe";
        }
        public Greet(string name)
        {
            this.name = name;
        }
        public void greet()
        {
            Console.WriteLine($"Good Morning, {name}!");
        }
    }
}

