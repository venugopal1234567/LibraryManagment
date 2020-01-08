using System;
using LibraryManagement.Entity;

namespace LibraryManagement.Presentation.Models
{
    public class LibraryBorrowViewModel
    {
        public string UserId { get; set; }
        public int BookId { get; set; }

        public  DateTime BorrowedDate {get; set;}

        public DateTime SubmittedDate { get; set; }

    }
}