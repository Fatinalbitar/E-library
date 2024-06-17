using E_Library.Data;
using E_Library.DTOS;
using E_Library.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;
using System.Diagnostics;
using System.Reflection;

namespace E_Library.Controllers
{
    public class UsersController : Controller
    {
        private readonly E_LibraryContext _context;
        private ISession _session;
        public UsersController(E_LibraryContext context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            this._session = httpContextAccessor.HttpContext.Session;
        }

        [HttpPost]
        public async Task<ActionResult> Logout()
        {
            var type = _session.GetString("Type").ToString();

            _session.Clear();
            if (type == "1")
                return RedirectToAction("Login");
            return RedirectToAction("Login", "Instructors");
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult UserDashBoard(int pageNumber)
        {
            if (!isUser())
                return RedirectToAction("Login");

            List<Book> books = new List<Book>();
            books = _context.Books.Select(x => new Book()
            {
                Id = x.Id,
                Name = x.Name,
                Author = x.Author,
                Category = x.Category,
                ImagePath = x.ImagePath,
                Shortcut = x.Shortcut,
                IsAvailable = (!_context.StudentBorrowBooks.Any(xx => xx.BookId == x.Id && xx.BorrowDate != null && xx.RecievedDate == null)),

            }).AsEnumerable()
            .OrderByDescending(x => x.Id)
            .Skip(pageNumber * 5)
                .Take(5)
                .ToList();

            var count = _context.Books.Count();

            return View(new PaginationData<Book>(books, pageNumber > 0 ? true : false, count > ((pageNumber + 1) * 5) ? true : false, pageNumber));
        }


        public IActionResult BorrowHistory(int pageNumber)
        {
            if (!isUser())
                return RedirectToAction("Login");

            var userId = int.Parse(_session.GetString("Id").ToString());

            List<StudentBorrowBooks> books = new List<StudentBorrowBooks>();

            books = books = _context.StudentBorrowBooks.Include(x => x.Book)
            .Where(x => x.StudentId == userId)
            .AsEnumerable()
            .OrderByDescending(x => x.Id)
            .Skip(pageNumber * 10)
            .Take(10).ToList();

            var count = _context.StudentBorrowBooks.Where(x => x.StudentId == userId).Count();

            return View(new PaginationData<StudentBorrowBooks>(books, pageNumber > 0 ? true : false, count > ((pageNumber + 1) * 10) ? true : false, pageNumber));
        }

        public IActionResult BorrowBook(int bookId)
        {
            var userId = int.Parse(_session.GetString("Id").ToString());

            _context.StudentBorrowBooks.Add(new StudentBorrowBooks()
            {
                BookId = bookId,
                StudentId = userId,
            });

            _context.SaveChanges();

            return RedirectToAction("UserDashBoard");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Login objUser)
        {
            var user = _context.Students.Where(a => a.Email == objUser.Email && a.Password == objUser.Password).FirstOrDefault();
            if (user != null)
            {
                _session.SetString("Id", user.Id.ToString());
                _session.SetString("Email", user.Email.ToString());
                _session.SetString("Name", user.Name.ToString());
                _session.SetString("Type", "1");

                return RedirectToAction("UserDashBoard");
            }
            return View(objUser);
        }

        private bool isUser()
        {
            int.TryParse(_session.GetString("Type")?.ToString() ?? "0", out int type);
            return type == 1;
        }
    }
}
