using Library_System.Delegates;
using Library_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_System.Interfaces;

namespace Library_System
{
    internal class Program
    {
        public static event NotificationHandler OnBorrow;

        static void Main(string[] args)
        {
            OnBorrow += ShowNotification;

            List<LibraryItem> items = new List<LibraryItem>();

            items.Add(new Book(1, "C# Programming", "Ahmed Ali"));
            items.Add(new Magazine(2, "Tech Magazine", 15));
            items.Add(new DVD(3, "OOP Tutorial", 120));

            foreach (LibraryItem item in items)
            {
                item.DisplayInfo();
                item.Borrow();

                OnBorrow?.Invoke($"Notification: {item.Title} was borrowed");

                Console.WriteLine();
            }

            Console.WriteLine($"Total Items: {LibraryItem.ItemCount}");

            Console.ReadLine();
        }

        static void ShowNotification(string message)
        {
            Console.WriteLine(message);
        }
    }
}