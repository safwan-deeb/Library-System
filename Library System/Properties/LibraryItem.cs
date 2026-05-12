using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_System.Properties
{
    public abstract class LibraryItem
    {
        private int id;
        private string title;

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
                title = value;
            }

        }
        public LibraryItem(int itemId, string itemTitle)
        {
            id = itemId;
            title = itemTitle;
        }
        public abstract void DisplayInfo();

        public virtual void Borrow()
        {
            {
                System.Console.WriteLine("Item borrowed");
            }
        }
        public virtual void Return()
        {
            {
                System.Console.WriteLine("Item returned");
            }
        }
    }
}