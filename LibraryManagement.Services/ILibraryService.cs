using System.Collections.Generic;
using System.Threading.Tasks;
using LibraryManagement.Entity;

namespace LibraryManagement.Services
{
    public interface ILibraryService
    {
         Task CreateAsync(User newUser);
         User GetById(int userId);
         Task UpdateAsync(User user);
         Task UpdateAsync(int id);

         Task Delete(int userId);

         IEnumerable<User> GetAll();

        Task Return(int bookId, int userId);
    }
}