using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_System.Models
{
    public class Magazine : LibraryItem
    {
        private int issueNumber;

        public int IssueNumber
        {
            get
            {
                return issueNumber;
            }
            set
            {
                issueNumber = value;
            }
        }

        public Magazine(int id, string title, int issue)
            : base(id, title)
        {
            issueNumber = issue;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("----- Magazine -----");
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Issue Number: {IssueNumber}");
        }

        public override void Borrow()
        {
            Console.WriteLine($"Magazine '{Title}' Borrowed Successfully");
        }

        public override void Return()
        {
            Console.WriteLine($"Magazine '{Title}' Returned Successfully");
        }
    }
}
