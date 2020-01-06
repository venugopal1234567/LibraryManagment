using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryManagement.Entity;
using LibraryManagement.Percistance;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagement.Services.Implimentation
{
    public class LibraryService : ILibraryService
    {
        private ApplicationDbContext _context;

        public LibraryService(ApplicationDbContext context)
        {
             _context = context;
        }
        // public async Task CreateAsync(User newUser)
        // {
        //    await _context.LibraryUsers.AddAsync(newUser);
        //    await _context.SaveChangesAsync();
        // }

        public async Task Delete(string userId)
        {
           var user = GetById(userId);
            _context.Remove(user);
            await _context.SaveChangesAsync();
        }

        public IEnumerable<ApplicationUser> GetAll() => _context.Users.ToList();

        public ApplicationUser GetById(string userId) {
          var borrowedBook = _context.BorrowRecords.Include(b => b.Users).Where(b => b.Users.Id == userId).ToList();
          var result=  _context.Users.Single(b => b.Id == userId);
          result.Borrows = borrowedBook;
          return result;
        }

        // public async Task UpdateAsync(User user)
        // {
        //    _context.Update(user);
        //    await _context.SaveChangesAsync();
        // }

        // public async Task UpdateAsync(string id)
        // {
        //      var user = GetById(id);
        //     _context.Update(user);
        //     await _context.SaveChangesAsync();
        // }
        
        public async Task Return(int bookId, string userId){
            var borrowRecord = _context.BorrowRecords.Where(b => b.BookId == bookId && b.UsersId == userId).FirstOrDefault();
            var existingUser=  _context.Users.Single(b => b.Id == userId );
            existingUser.Borrows.Remove(borrowRecord);
            _context.Update(existingUser);
            await _context.SaveChangesAsync();
        }

    }
}