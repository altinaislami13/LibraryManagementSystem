using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryApp.Models;

namespace LibraryApp.Utils
{
    public static class Pagination
    {
        public static void ShowItems(List<Item> items, int page)
        {
            int pageSize = 10;
            var pageItems = items
                .Skip((page - 1) * pageSize)
                .Take(pageSize);

            foreach (var item in pageItems)
            {
                string status = item.IsAvailable ? "Available" : "Borrowed";
                Console.WriteLine($"{item.Id}. {item.Title} [{status}]");
            }
        }
    }

}
