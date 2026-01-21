using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryApp.Models;
using LibraryApp.People;

namespace LibraryApp.Services
{
    public class LibraryService
    {
        public List<Item> Items { get; set; } = new();
        public List<Loan> Loans { get; set; } = new();

        public void BorrowItem(int itemId, Member member)
        {
            var item = Items.FirstOrDefault(i => i.Id == itemId);
            if (item == null)
                throw new Exception("Item not found");


            item.Borrow();


            Loans.Add(new Loan
            {
                ItemId = itemId,
                MemberId = member.Id,
                BorrowDate = DateTime.Now
            });
        }


        public void ReturnItem(int itemId)
        {
            var item = Items.First(i => i.Id == itemId);
            item.Return();


            var loan = Loans.First(l => l.ItemId == itemId && l.ReturnDate == null);
            loan.ReturnDate = DateTime.Now;
        }


        public decimal CalculateLateFee(Loan loan, Member member)
        {
            DateTime dueDate = loan.BorrowDate.AddDays(14);
            if (DateTime.Now <= dueDate) return 0;


            int daysLate = (DateTime.Now - dueDate).Days;
            return daysLate * member.LateFeePerDay;
        }
    }
}

