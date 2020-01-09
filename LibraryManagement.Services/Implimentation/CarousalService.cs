using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryManagement.Entity;
using LibraryManagement.Percistance;

namespace LibraryManagement.Services.Implimentation
{
    public class CarousalService : ICarousalService
    {
        private ApplicationDbContext _context;

        public CarousalService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task CreateAsync(Carousel newCarousal)
        {
              await _context.Carousels.AddAsync(newCarousal);
              await _context.SaveChangesAsync();
        }

        public async Task Delete(int carousalId)
        {
             var carousel = GetById(carousalId);
            _context.Remove(carousel);
            await _context.SaveChangesAsync();
        }

        public Carousel GetById(int carousalId) => _context.Carousels.Where(c => c.Id == c.BookId).FirstOrDefault();

        public IEnumerable<Book> GetAll() {

           List<Book> bokResult = new List<Book>();
           var result = from carousel in _context.Carousels
                    join book in _context.Books
                        on carousel.BookId equals book.Id
                            select new 
                            { 
                                Title = book.Title, 
                                Image = book.ImageUrl
                            };

           foreach(var res in result ){
              var bookModel = new Book(){
                   Title = res.Title,
                   ImageUrl = res.Image
              };
             bokResult.Add(bookModel);
           }
           return bokResult;
        }
    }
}