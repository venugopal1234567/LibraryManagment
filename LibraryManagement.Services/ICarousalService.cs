using System.Collections.Generic;
using System.Threading.Tasks;
using LibraryManagement.Entity;

namespace LibraryManagement.Services
{
    public interface ICarousalService
    {
          Task CreateAsync(Carousel newCarousal);

          Task Delete(int carousalId);

          IEnumerable<Book> GetAll();

          Carousel GetById(int carousalId);
    }
}