using System.Collections.Generic;
using LibraryManagement.Entity;

namespace LibraryManagement.Presentation.Models
{
    public class LibraryUserEditViewModel
    {
         public int Id { get; set; }         
        public string Username { get; set; } 
        public long PhoneNumber { get; set; }
    }
}