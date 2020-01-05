using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryManagement.Entity;
using LibraryManagement.Presentation.Models;
using LibraryManagement.Services;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagement.Presentation.Controllers
{
    public class LibraryUserController : Controller
    {
         private ILibraryService _libraryService;
        private IBookService _bookService;

        public LibraryUserController(ILibraryService libraryService , IBookService bookService)
        {
            _libraryService = libraryService;
            _bookService = bookService;
        }

        public IActionResult Index(){
            ViewData["Title"] = "Home";
            var users = _libraryService.GetAll().Select(user => new LibraryUserIndexViewModel{
                Id = user.Id,
                Username = user.Username,
                PhoneNumber = user.PhoneNumber
            }).ToList();
            return View(users);
        }

        public IActionResult Create(){
            ViewData["Title"] = "Create";
            var model = new LibraryUserCreateViewModel();
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(LibraryUserCreateViewModel newUser){
           if(ModelState.IsValid){
               var model = new User(){
                 Id = newUser.Id,
                 Username = newUser.Username,
                 PhoneNumber = newUser.PhoneNumber
               };
               await _libraryService.CreateAsync(model);
               return RedirectToAction(nameof(Index));
           }
           return View();
           
        }
        public IActionResult Edit(int id){
            ViewData["Title"] = "Edit";
            var user = _libraryService.GetById(id);
            if(user == null){
                return NotFound();
            }
            var model = new LibraryUserEditViewModel (){
                  Id = user.Id,
                  Username = user.Username,
                  PhoneNumber = user.PhoneNumber

            };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(LibraryUserEditViewModel upUser){
           
           if(ModelState.IsValid){
               var user = _libraryService.GetById(upUser.Id);
               if(user == null){
                   return NotFound();
               }
               user.Username = upUser.Username;
               user.PhoneNumber = upUser.PhoneNumber;
               await _libraryService.UpdateAsync(user);
               return RedirectToAction(nameof(Index));
           }
           return View();
        }

        public IActionResult Detail(int id){
           ViewData["Title"] = "Detail";
           List<Book> bookList = new List<Book>();
           var user = _libraryService.GetById(id);
           if(user == null){
               return NotFound();
           }
           foreach(var item in user.Borrows){
              var book = _bookService.GetById(item.BookId);
              bookList.Add(book);
           }
           var model = new LibraryUserDetailViewModel(){
                 Id = user.Id,
                 Username = user.Username,
                 PhoneNumber = user.PhoneNumber,
                 Books = bookList
           };
            return View(model);
        }

        public IActionResult Delete(int id){
            ViewData["Title"] = "Delete";
            var user = _libraryService.GetById(id);
            if(user == null){
                return NotFound();
            }
            var model = new LibraryDeleteViewModel(){
                Id = user.Id,
                Username= user.Username
            };
            return View(model);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(LibraryDeleteViewModel model){
            await _libraryService.Delete(model.Id);
            return RedirectToAction(nameof(Index));
        }

         public async Task<IActionResult> ReturnRecord(int bookId, int userId){
            await _libraryService.Return(bookId, userId);
            return RedirectToAction("Detail", new { id = userId});

        }
    }
}