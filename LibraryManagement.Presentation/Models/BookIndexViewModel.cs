using System;
using LibraryManagement.Entity;

namespace LibraryManagement.Presentation.Models
{
    public class BookIndexViewModel
    {
        public int Id {get; set;}

        public string Author { get; set; } 

        public string Title { get; set; }

        public string Publisher { get; set; }

        public DateTime Year { get; set; }

        public int Pages { get; set; }

        public string Language { get; set; }

        public string ImageUrl {get; set;}
        public int Stock { get; set; }

        public BookCategory bookCategory { get; set; }
    }
}