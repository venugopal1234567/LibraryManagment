using System;
using System.ComponentModel.DataAnnotations;
using LibraryManagement.Entity;
using Microsoft.AspNetCore.Http;

namespace LibraryManagement.Presentation.Models
{
    public class BookEditViewModel
    {
       
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string Author { get; set; }

        [Required(ErrorMessage = "Title is Required"), StringLength(50, MinimumLength = 2)]
        public string Title { get; set; }

        [Required(ErrorMessage = "Publisher name is required"), StringLength(50, MinimumLength = 2)]
        public string Publisher { get; set; }

        [DataType(DataType.Date), Display(Name = "Published Date")]
        [Required(ErrorMessage = "Published date is required")]
        public DateTime Year { get; set; }

        [Required(ErrorMessage = "Number of pages is required")]
        public int Pages { get; set; }

        [Required(ErrorMessage = "Laanguage is Required"), StringLength(10, MinimumLength = 2)]
        public string Language { get; set; }

        public IFormFile ImageUrl { get; set; }

        [Required(ErrorMessage = "Stock is required")]
        public int Stock { get; set; }

        public BookCategory bookCategory { get; set; }

    }
}