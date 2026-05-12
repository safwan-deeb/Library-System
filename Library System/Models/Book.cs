using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_System.Models
{
    public class Book : LibraryItem
    {
        private string author;

        public string Author
        {
            get
            {
                return author;
            }
            set
            {
                author = value;
            }
        }

        public Book(int id, string title, string authorName)
            : base(id, title)
        {
            author = authorName;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("----- Book -----");
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
        }

        public override void Borrow()
        {
            Console.WriteLine($"Book '{Title}' Borrowed Successfully");
        }

        public override void Return()
        {
            Console.WriteLine($"Book '{Title}' Returned Successfully");
        }
    }
}