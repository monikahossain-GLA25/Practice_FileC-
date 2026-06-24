using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceConsoleApp
{
    class FictionBook : Book
    {
        public string Genre { get; set; }
        public FictionBook(string title, string author, double price, string genre) : base(title, author, price)
        {
            {
                Genre = genre;
            }
        }
    }
}
