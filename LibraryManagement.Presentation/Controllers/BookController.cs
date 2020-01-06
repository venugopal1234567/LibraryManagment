using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using LibraryManagement.Entity;
using LibraryManagement.Presentation.Models;
using LibraryManagement.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;

namespace LibraryManagement.Presentation.Controllers
{
    public class BookController : Controller
    {
        private IBookService _bookService;
        private readonly IHostingEnvironment  _hostingEnvironment;
        private readonly ILibraryService _libraryService;

        public BookController(IBookService bookService , IHostingEnvironment hostingEnvironment, ILibraryService libraryService)
        {
            _bookService = bookService;
            _hostingEnvironment = hostingEnvironment;
            _libraryService = libraryService;
        }

        [Authorize(Roles = "Admin, Student")]
        public IActionResult Index(){
            ViewData["Title"] = "Home";
            var books = _bookService.GetAll().Select(book => new BookIndexViewModel{
                Id = book.Id,
                Author = book.Author,
                Title = book.Title,
                Publisher = book.Publisher,
                Year = book.Year,
                Pages = book.Pages,
                Language = book.Language,
                ImageUrl = book.ImageUrl
            }).ToList();
            return View(books);
        }
        
        [Authorize(Roles = "Admin")]
        public IActionResult Create(){
            ViewData["Title"] = "Create";
            var model = new BookCreateViewModel();
            return View(model);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(BookCreateViewModel newBook){
           if(ModelState.IsValid){
               var model = new Book(){
                 Id = newBook.Id,
                 Author = newBook.Author,
                 Title = newBook.Title,
                 Publisher = newBook.Publisher,
                 Year = newBook.Year,
                 Pages = newBook.Pages,
                 Language = newBook.Language,
                 Stock = newBook.Stock
               };
               if(newBook.ImageUrl != null & newBook.ImageUrl.Length >0){
                   var uploadDir = @"images/book";
                   var fileName = Path.GetFileNameWithoutExtension(newBook.ImageUrl.FileName);
                   var extension = Path.GetExtension(newBook.ImageUrl.FileName);
                   var webRootPath = _hostingEnvironment.WebRootPath;
                   fileName = DateTime.UtcNow.ToString("yymmssfff")+fileName+extension;
                   var path = Path.Combine(webRootPath, uploadDir, fileName);
                   await newBook.ImageUrl.CopyToAsync(new FileStream(path, FileMode.Create));
                   model.ImageUrl = "/"+uploadDir+"/"+fileName;
               }
               await _bookService.CreateAsync(model);
               return RedirectToAction(nameof(Index));
           }
           return View();
           
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Edit(int id){
            ViewData["Title"] = "Edit";
            var book = _bookService.GetById(id);
            if(book == null){
                return NotFound();
            }
            var model = new BookEditViewModel (){
                  Id = book.Id,
                 Author = book.Author,
                 Title = book.Title,
                 Publisher = book.Publisher,
                 Year = book.Year,
                 Pages = book.Pages,
                 Language = book.Language,
                 Stock = book.Stock
            };
            return View(model);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(BookEditViewModel upBook){
           
           if(ModelState.IsValid){
               var book = _bookService.GetById(upBook.Id);
               if(book == null){
                   return NotFound();
               }
               book.Author = upBook.Author;
               book.Language = upBook.Language;
               book.Pages = upBook.Pages;
               book.Publisher = upBook.Publisher;
               book.Stock = upBook.Stock;
               book.Title = upBook.Title;
               book.Year = upBook.Year;
               if(upBook.ImageUrl != null && upBook.ImageUrl.Length > 0){
                    var uploadDir = @"images/book";
                   var fileName = Path.GetFileNameWithoutExtension(upBook.ImageUrl.FileName);
                   var extension = Path.GetExtension(upBook.ImageUrl.FileName);
                   var webRootPath = _hostingEnvironment.WebRootPath;
                   fileName = DateTime.UtcNow.ToString("yymmssfff")+fileName+extension;
                   var path = Path.Combine(webRootPath, uploadDir, fileName);
                   await upBook.ImageUrl.CopyToAsync(new FileStream(path, FileMode.Create));
                   book.ImageUrl = "/"+uploadDir+"/"+fileName;
               }
               await _bookService.UpdateAsync(book);
               return RedirectToAction(nameof(Index));
           }
           return View();
        }

        [Authorize(Roles = "Admin, Student")]
        public IActionResult Detail(int id){
           ViewData["Title"] = "Detail";
           var book = _bookService.GetById(id);
           if(book == null){
               return NotFound();
           }
           var model = new BookDetailViewModel(){
                 Id = book.Id,
                Author = book.Author,
                Title = book.Title,
                Publisher = book.Publisher,
                Year = book.Year,
                Pages = book.Pages,
                Language = book.Language,
                ImageUrl = book.ImageUrl
           };
            return View(model);
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Delete(int id){
            ViewData["Title"] = "Delete";
            var book = _bookService.GetById(id);
            if(book == null){
                return NotFound();
            }
            var model = new BookDeleteViewModel(){
                Id = book.Id,
                Title = book.Title
            };
            return View(model);
        }

        
        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(BookDeleteViewModel model){
            await _bookService.Delete(model.Id);
            return RedirectToAction(nameof(Index));
        }

        [Authorize(Roles = "Admin, Student")]
        public IActionResult BorrowRecord (int id){
          var tempUserList  = _libraryService.GetAll().ToList();
          var selectUser = tempUserList.Select(c => new { 
               ID = c.Id, 
              UserName = c.UserName
           }).ToList();
          ViewBag.SelectUser = new MultiSelectList(selectUser, "ID", "UserName");
          var model = new LibraryBorrowViewModel(){
              BookId = id
          };
          return View(model);
        }

        [Authorize(Roles = "Admin, Student")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> BorrowRecord(LibraryBorrowViewModel model){
            var newBorrowRecord = new BorrowRecord(){
               BookId = model.BookId,
               UsersId = model.UserId
            };
            await _bookService.Borrow(newBorrowRecord);
            return RedirectToAction("Detail","LibraryUser", new { id = model.UserId});

        }

    }
}