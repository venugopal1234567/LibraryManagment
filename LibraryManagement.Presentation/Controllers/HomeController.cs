using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using LibraryManagement.Presentation.Models;
using LibraryManagement.Services;
using LibraryManagement.Entity;

namespace LibraryManagement.Presentation.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICarousalService _carousalService;
        private readonly IBookService _bookService;

        public HomeController(ILogger<HomeController> logger, ICarousalService carousalService, IBookService bookService)
        {
            _logger = logger;
            _carousalService = carousalService;
            _bookService= bookService;
        }

        public IActionResult Index()
        {
            var model = new HomeIndexViewModel();
            var carousels = _carousalService.GetAll();
            var categories = _bookService.GetBookCategories();
            model.Books = carousels.ToList();
            model.Categories = categories.ToList();
            model.HomeBooks = _bookService.GetTopBooks().ToList();
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }
 
        public async Task<ActionResult> UploadSliderImage(int bookId)  
        {  
            var newCarousalModel = new Carousel(){
                BookId = bookId
            };
            await _carousalService.CreateAsync(newCarousalModel);

            return View("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
