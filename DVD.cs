using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Models
{
    public class DVD : Item
    {
        public int DurationMinutes { get; private set; }


        public DVD(int id, string title, int durationMinutes)
        : base(id, title)
        {
            DurationMinutes = durationMinutes;
        }
    }
}
