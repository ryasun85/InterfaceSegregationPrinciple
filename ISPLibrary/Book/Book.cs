using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPLibrary
{
    internal class Book : IBorrowableBook
    {
        public string LibraryID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int CheckoutDurationInDays { get; set; }
        public int Pages { get; set; }
        public DateTime BorrowDate { get; set; }
        public string Borrower { get; set; }

        public void CheckOut(string borrower)
        {
            Borrower = borrower;
            BorrowDate = DateTime.Now;
        }
        public void CheckIn()
        {
            Borrower = "";
        }

        public DateTime GetDueDate()
        {
            return BorrowDate.AddDays(CheckoutDurationInDays);
        }
    }
}
