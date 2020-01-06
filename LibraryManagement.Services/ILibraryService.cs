using System.Collections.Generic;
using System.Threading.Tasks;
using LibraryManagement.Entity;
using Microsoft.AspNetCore.Identity;

namespace LibraryManagement.Services
{
    public interface ILibraryService
    {
        //  Task CreateAsync(User newUser);
         ApplicationUser GetById(string userId);
        //  Task UpdateAsync(User user);
        //  Task UpdateAsync(string id);

         Task Delete(string userId);

         IEnumerable<ApplicationUser> GetAll();

        Task Return(int bookId, string userId);
    }
}