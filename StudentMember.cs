using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.People
{
    public class StudentMember : Member
    {
        public StudentMember(int id, string name) : base(id, name) { }
        public override decimal LateFeePerDay => 0.50m;
    }
}
