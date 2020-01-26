using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.Entity
{
    public class BookCategory
    {
        public int Id { get; set; }

        public string categoryName { get; set; }
    }
}