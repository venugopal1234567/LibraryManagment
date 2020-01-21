using System;
using LibraryManagement.Entity;
using LibraryManagement.Presentation.Infrastructure;

namespace LibraryManagement.Presentation.Models
{
    public class LibraryBorrowViewModel
    {
        public LibraryBorrowViewModel()
        {
            SubmittedDate = DateTime.Now;
        }
        public string UserId { get; set; }
        public int BookId { get; set; }

        public  DateTime BorrowedDate {get; set;}

         [BorrowDateValidation(ErrorMessage ="Please enter date between next 15 days from today")]
        public DateTime SubmittedDate { get; set; }

    }
}