using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    internal class Book
    {
        protected string title;
        protected string author;

        public Book(string title, string author)
        {
            this.title = title;
            this.author = author;
        }

        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Book Name:{title}");
            Console.WriteLine($"Book Author:{author}");
        }

    }
    class EBook : Book
    {
        double filesize;
        string format;

        public EBook(string title, string author, double filesize, string format) : base(title, author)
        {
            this.filesize = filesize;
            this.format = format;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"Book Name:{title}");
            Console.WriteLine($"Book Author:{author}");
            Console.WriteLine($"File Size:{filesize}");
            Console.WriteLine($"Format:{format}");


        }


    }
}