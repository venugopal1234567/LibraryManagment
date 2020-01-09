using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagement.Entity
{
    public class Carousel
    {
        public int Id { get; set; } 

        [ForeignKey("Book")]
        public int BookId { get; set; }
    }
}