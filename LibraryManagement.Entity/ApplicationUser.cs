using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace LibraryManagement.Entity
{
    public class ApplicationUser  : IdentityUser
    {
        public ApplicationUser()
        {
           this.Borrows = new HashSet<BorrowRecord>();
        }     

        public string Gender { get; set; }   
        public virtual ICollection<BorrowRecord> Borrows { get; set; }

    }
}