using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_7
{
    class Book
    {

        public string Title { get; set; }
        public string Autor { get; set; }

        // Ctor 01 [Default Constructor]

        public Book()
        {
            Title = "Sea";
            Autor = "Ctor 01";
        }

        // Ctor 02
        public Book(string _Title) : this()
        {
            Title = _Title;
        }

        // Ctor 03
        public Book(string _Title, string _Author)
        {
            Title = _Title;
            Autor = _Author;
        }

        public override string ToString()
        {
            return $"The Book Title: {Title}, The Book Autor: {Autor}";
        }

    }
}
