using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryManagement.Entity;
using LibraryManagement.Presentation.Models;
using LibraryManagement.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagement.Presentation.Controllers
{

    public class LibraryUserController : Controller
    {
         private ILibraryService _libraryService;
        private IBookService _bookService;

        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
    
         private readonly RoleManager<IdentityRole> _roleManager;

        public LibraryUserController(ILibraryService libraryService , 
        IBookService bookService,
         SignInManager<ApplicationUser> signInManager, 
          UserManager<ApplicationUser> userManager,
          RoleManager<IdentityRole> roleManager)
        {
            _libraryService = libraryService;
            _bookService = bookService;
            _signInManager = signInManager;
            _userManager = userManager;
        }

        [Authorize(Roles = "Admin, Student")]
        public IActionResult Index(){
            ViewData["Title"] = "Home";
            var users = _libraryService.GetAll().Select(user => new LibraryUserIndexViewModel{
                Id = user.Id,
                Username = user.UserName,
                PhoneNumber = user.PhoneNumber
            }).ToList();
            return View(users);
        }

        // [Authorize(Roles = "Admin")]
        // public IActionResult Create(){
        //     ViewData["Title"] = "Create";
        //     var model = new LibraryUserCreateViewModel();
        //     return View(model);
        // }

        // [Authorize(Roles = "Admin")]
        // [HttpPost]
        // [ValidateAntiForgeryToken]
        // public async Task<IActionResult> Create(LibraryUserCreateViewModel newUser){
        //    if(ModelState.IsValid){
        //        var model = new User(){
        //          Id = newUser.Id,
        //          UserName = newUser.UserName,
        //          PhoneNumber = newUser.PhoneNumber
        //        };
        //        await _libraryService.CreateAsync(model);
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View();
           
        // }

        // [Authorize(Roles = "Admin")]
        // public IActionResult Edit(string id){
        //     ViewData["Title"] = "Edit";
        //     var user = _libraryService.GetById(id);
        //     if(user == null){
        //         return NotFound();
        //     }
        //     var model = new LibraryUserEditViewModel (){
        //           Id = user.Id,
        //           Username = user.UserName,
        //           PhoneNumber = user.PhoneNumber

        //     };
        //     return View(model);
        // }

        // [Authorize(Roles = "Admin")]
        // [HttpPost]
        // [ValidateAntiForgeryToken]
        // public async Task<IActionResult> Edit(LibraryUserEditViewModel upUser){
           
        //    if(ModelState.IsValid){
        //        var user = _libraryService.GetById(upUser.Id);
        //        if(user == null){
        //            return NotFound();
        //        }
        //        user.UserName = upUser.Username;
        //        user.PhoneNumber = upUser.PhoneNumber;
        //        await _libraryService.UpdateAsync(user);
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View();
        // }

        [Authorize(Roles = "Admin, Student")]
        public IActionResult Detail(string id){
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
                 Username = user.UserName,
                 PhoneNumber = user.PhoneNumber,
                 Books = bookList
           };
            return View(model);
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Delete(string id){
            ViewData["Title"] = "Delete";
            var user = _libraryService.GetById(id);
            if(user == null){
                return NotFound();
            }
            var model = new LibraryDeleteViewModel(){
                Id = user.Id,
                Username= user.UserName
            };
            return View(model);
        }

        
        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(LibraryDeleteViewModel model){
            await _libraryService.Delete(model.Id);
            return RedirectToAction(nameof(Index));
        }


        [Authorize(Roles = "Admin, Student")]
         public async Task<IActionResult> ReturnRecord(int bookId, string userId){
            await _libraryService.Return(bookId, userId);
            return RedirectToAction("Detail", new { id = userId});

        }
    }
}