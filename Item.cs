using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Models
{
    public abstract class Item
    {
        public int Id { get; protected set; }
        public string Title { get; protected set; }
        public bool IsAvailable { get; protected set; } = true;


        protected Item(int id, string title)
        {
            Id = id;
            Title = title;
        }


        public virtual void Borrow()
        {
            if (!IsAvailable)
                throw new Exception("Item is not available");


            IsAvailable = false;
        }


        public virtual void Return()
        {
            IsAvailable = true;
        }
    }
}
