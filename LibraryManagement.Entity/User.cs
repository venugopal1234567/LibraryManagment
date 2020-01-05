using System.Collections.Generic;

namespace LibraryManagement.Entity
{
    public class User
    {
        public User()
        {
           this.Borrows = new HashSet<BorrowRecord>();
        } 
        public int Id { get; set; }         
        public string Username { get; set; } 
        public long PhoneNumber { get; set; }
        public virtual ICollection<BorrowRecord> Borrows { get; set; }
    }
}