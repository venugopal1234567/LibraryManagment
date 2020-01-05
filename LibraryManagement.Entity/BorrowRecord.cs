using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagement.Entity
{
    public class BorrowRecord
    {
        public int Id {get; set;} 
        public int BookId {get; set;}
        public  DateTime BorrowedDate {get; set;}

        public DateTime SubmittedDate { get; set; }

        public virtual User Users { get; set; }

        public int UsersId {get; set;}

    }
}