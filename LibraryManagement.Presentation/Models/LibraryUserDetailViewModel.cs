using System.Collections.Generic;
using LibraryManagement.Entity;

namespace LibraryManagement.Presentation.Models
{
    public class LibraryUserDetailViewModel
    {
         public string Id { get; set; }         
        public string Username { get; set; } 
        public string PhoneNumber { get; set; }
        
         public int BorrowId {get; set;}
         public IEnumerable<Book> Books { get; set; }
    }
}