using System.Collections.Generic;
using LibraryManagement.Entity;

namespace LibraryManagement.Presentation.Models
{
    public class LibraryUserDetailViewModel
    {
         public int Id { get; set; }         
        public string Username { get; set; } 
        public long PhoneNumber { get; set; }
        
         public int BorrowId {get; set;}
         public IEnumerable<Book> Books { get; set; }
    }
}