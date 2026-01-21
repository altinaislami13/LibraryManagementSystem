using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Models
{
    public class Magazine : Item
    {
        public int IssueNumber { get; private set; }


        public Magazine(int id, string title, int issueNumber)
        : base(id, title)
        {
            IssueNumber = issueNumber;
        }
    }
}
