using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryManagement.Entity;
using LibraryManagement.Percistance;

namespace LibraryManagement.Services.Implimentation
{
    public class BookService : IBookService
    {
        private ApplicationDbContext _context;

        public BookService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task  CreateAsync(Book newBook)
        {
           await _context.Books.AddAsync(newBook);
           await _context.SaveChangesAsync();
        }

        public Book GetById(int bookId) => _context.Books.Where(b => b.Id == bookId).FirstOrDefault();

        public async Task Delete(int bookId)
        {
            var book = GetById(bookId);
            _context.Remove(book);
            await _context.SaveChangesAsync();
        }

        public IEnumerable<Book> GetAll() => _context.Books;


        public async Task UpdateAsync(Book book)
        {
           _context.Update(book);
           await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(int id)
        {
            var book = GetById(id);
            _context.Update(book);
            await _context.SaveChangesAsync();
        }

        public async Task Borrow (BorrowRecord borrowRecord){
            var existingUser=  _context.Users.Single(u => u.Id == borrowRecord.UsersId.ToString());
             var book = _context.Books.Single(b => b.Id == borrowRecord.BookId);
             var isBorrowRecord = _context.BorrowRecords.Where(b => b.BookId == borrowRecord.BookId && b.UsersId == borrowRecord.UsersId).FirstOrDefault();
             if(isBorrowRecord == null && book.Stock >0){
                book.Stock--;
               existingUser.Borrows.Add(borrowRecord);
               _context.Update(book);
               _context.Update(existingUser);
               await _context.SaveChangesAsync();
             }
            
        }

        public IEnumerable<Book> Search(string title){
            return _context.Books.Where(data => data.Title.ToLower().StartsWith(title.ToLower()) ).ToList();
        }

    }
}