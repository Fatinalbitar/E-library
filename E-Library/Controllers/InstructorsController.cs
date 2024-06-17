using E_Library.Data;
using E_Library.DTOS;
using E_Library.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace E_Library.Controllers
{
    public class InstructorsController : Controller
    {
        private readonly E_LibraryContext _context;
        private ISession _session;
        public InstructorsController(E_LibraryContext context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            this._session = httpContextAccessor.HttpContext.Session;
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult InstructorDashBoard(int pageNumber)
        {
            if (!isInstructor())
                return RedirectToAction("Login");

            List<StudentBorrowBooks> books = new List<StudentBorrowBooks>();

            books = _context.StudentBorrowBooks.Include(x => x.Student).Include(x => x.Book)
                .AsEnumerable()
                .OrderByDescending(x => x.Id)
                .Skip(pageNumber * 10)
                .Take(10).ToList();

            var count = _context.StudentBorrowBooks.Include(x => x.Student).Include(x => x.Book).Count();

            return View(new PaginationData<StudentBorrowBooks>(books,pageNumber > 0 ? true : false, count > ((pageNumber + 1) * 10) ? true : false, pageNumber));

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Login objUser)
        {
            var instructor = _context.Instructors.Where(a => a.Email == objUser.Email && a.Password == objUser.Password).FirstOrDefault();
            if (instructor != null)
            {
                _session.SetString("Id", instructor.Id.ToString());
                _session.SetString("Email", instructor.Email.ToString());
                _session.SetString("Name", instructor.Name.ToString());
                _session.SetString("Type", "2");

                return RedirectToAction("InstructorDashBoard");
            }
            return View(objUser);
        }


        public IActionResult BorrowBook(int studentBorrowBookId)
        {
            var userId = int.Parse(_session.GetString("Id").ToString());

            var obj = _context.StudentBorrowBooks.Where(x => x.Id == studentBorrowBookId).First();
            obj.BorrowDate = DateTime.Now;
            _context.SaveChanges();

            return RedirectToAction("InstructorDashBoard");


        }


        public IActionResult RecieveBook(int studentBorrowBookId)
        {
            var userId = int.Parse(_session.GetString("Id").ToString());

            var obj = _context.StudentBorrowBooks.Where(x => x.Id == studentBorrowBookId).First();
            obj.RecievedDate = DateTime.Now;
            _context.SaveChanges();

            return RedirectToAction("InstructorDashBoard");


        }

        private bool isInstructor()
        {
            int.TryParse(_session.GetString("Type")?.ToString() ?? "0", out int type);
            return type == 2;
        }

    }
}
