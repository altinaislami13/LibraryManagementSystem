using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Models
{
    public class Book : Item
    {
        public string Author { get; private set; }
        public int Year { get; private set; }
        public int Pages { get; private set; }

        public Book(int id, string title, string author, int year, int pages)
            : base(id, title)
        {
        
            Author = author;
            Year = year;
            Pages = pages;
      
        }
    }
}

