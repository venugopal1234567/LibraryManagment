using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagement.Entity
{
    public class Book
    {
        
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string Author { get; set; } 

        [Required, MaxLength(100)]
        public string Title { get; set; }

        [Required, MaxLength(50)]
        public string Publisher { get; set; }

        public DateTime Year { get; set; }

        [Required]
        public int Pages { get; set; }

         [Required, MaxLength(7)]
        public string Language { get; set; }

        public string ImageUrl {get; set;}

       public IEnumerable<BorrowRecord> BorrowRecords {get; set;} 

        public int Stock { get; set; }

        public BookCategory BookCategories {get; set;}

    }
}