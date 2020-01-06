using System;
using System.Collections.Generic;
using System.Text;
using LibraryManagement.Entity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace LibraryManagement.Percistance
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
       //  public DbSet<User> Users {get; set;}

          public DbSet<Book> Books {get; set;}

        //   public DbSet<User> LibraryUsers {get; set;}

          public DbSet<BorrowRecord> BorrowRecords { get; set; }
    }
}
