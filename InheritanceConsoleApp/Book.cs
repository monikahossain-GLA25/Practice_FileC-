using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceConsoleApp
{
     class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public double Price { get; set; }

      public Book(string title, string author , double price)
        {
            Title = title;
            Author = author;
            Price = price;
        }

       

        public void DisplayInfo()
        {
            
            Console.WriteLine(Title);
            Console.WriteLine(Author);
            Console.WriteLine(Price);
        }
    }
}
