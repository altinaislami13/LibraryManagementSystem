using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.People
{
    public abstract class Person
    {
        public int Id { get; protected set; }
        public string Name { get; protected set; }


        protected Person(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
