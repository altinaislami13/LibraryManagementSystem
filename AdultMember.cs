using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.People
{
    public class AdultMember : Member
    {
        public AdultMember(int id, string name) : base(id, name) { }
        public override decimal LateFeePerDay => 1.00m;
    }
}
