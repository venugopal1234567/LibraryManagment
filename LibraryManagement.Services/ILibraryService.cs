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
         Task UpdateAsync(ApplicationUser user);
         Task UpdateAsync(string id);

         Task Delete(string userId);

         IEnumerable<ApplicationUser> GetAll();

         IEnumerable<ApplicationUser> Search(string userName);

        Task Return(int bookId, string userId);
    }
}