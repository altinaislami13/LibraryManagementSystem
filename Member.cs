using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.People
{
    public abstract class Member : Person
    {
        protected Member(int id, string name) : base(id, name) { }


        public abstract decimal LateFeePerDay { get; }
    }
}
