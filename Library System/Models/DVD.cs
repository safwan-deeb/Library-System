using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_System.Models
{
    public class DVD : LibraryItem
    {
        private int duration;

        public int Duration
        {
            get
            {
                return duration;
            }
            set
            {
                duration = value;
            }
        }

        public DVD(int id, string title, int dvdDuration)
            : base(id, title)
        {
            duration = dvdDuration;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("----- DVD -----");
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Duration: {Duration} Minutes");
        }

        public override void Borrow()
        {
            Console.WriteLine($"DVD '{Title}' Borrowed Successfully");
        }

        public override void Return()
        {
            Console.WriteLine($"DVD '{Title}' Returned Successfully");
        }
    }
}