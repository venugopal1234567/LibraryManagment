using System.Collections.Generic;
using System.Threading.Tasks;
using LibraryManagement.Entity;

namespace LibraryManagement.Services
{
    public interface IBookService
    {
         Task CreateAsync(Book newBook);
         Book GetById(int bookId);
         Task UpdateAsync(Book book);
         Task UpdateAsync(int id);

         Task Delete(int bookId);

         IEnumerable<Book> GetAll();

         Task Borrow (BorrowRecord borrowRecord);

         IEnumerable<Book> Search(string title);

         IEnumerable<BookCategory> GetBookCategories();

          BookCategory GetCategoryById(int id);

          IEnumerable<Book> GetBooksByCategory(int id);

          IEnumerable<Book> GetTopBooks();
    }
}