using System.Collections.Generic;
using LibraryManagement.Entity;

namespace LibraryManagement.Presentation.Models
{
    public class HomeIndexViewModel
    {
        public List<Book> Books { get; set; }

        public List<BookCategory> Categories {get; set;}

        public List<Book> HomeBooks {get; set;}
    }
}