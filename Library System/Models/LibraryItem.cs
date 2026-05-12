using Library_System.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Library_System.Models
{
    public abstract class LibraryItem : IBorrowable
    {
        private int id;
        private string title;

        public static int ItemCount { get; set; }

        public int Id
        {
            get
            {
                return id;
            }
        }

        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    title = value;
                }
            }
        }

        public LibraryItem(int itemId, string itemTitle)
        {
            id = itemId;
            title = itemTitle;

            ItemCount++;
        }

        public abstract void DisplayInfo();

        public virtual void Borrow()
        {
            Console.WriteLine("Item Borrowed");
        }

        public virtual void Return()
        {
            Console.WriteLine("Item Returned");
        }
    }
}