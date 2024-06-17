using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using E_Library.Data;
using E_Library.Models;
using E_Library.DTOS;
using Microsoft.AspNetCore.Http;

namespace E_Library.Controllers
{
    public class BooksController : Controller
    {
        private readonly E_LibraryContext _context;
        private ISession _session;


        public BooksController(E_LibraryContext context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            this._session = httpContextAccessor.HttpContext.Session;
        }

        public IActionResult Index(int pageNumber)
        {
            if (!isInstructor())
                return RedirectToAction("Login", "Instructors");

            List<Book> books = new List<Book>();

            books = _context.Books.AsEnumerable().OrderByDescending(x => x.Id).Skip(pageNumber * 5).Take(5).ToList();

            var count = _context.Books.Count();

            return View(new PaginationData<Book>(books, pageNumber > 0 ? true : false, count > ((pageNumber + 1) * 5) ? true : false, pageNumber));
        }

        public IActionResult Details(int? id)
        {
            if (!isInstructor())
                return RedirectToAction("Login", "Instructors");

            if (id == null)
            {
                return NotFound();
            }

            var book = _context.Books
                .FirstOrDefault(m => m.Id == id);
            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }

        public IActionResult Create()
        {
            if (!isInstructor())
                return RedirectToAction("Login", "Instructors");

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Id,Name,ImagePath,Author,Shortcut,Category")] Book book)
        {
            if (!isInstructor())
                return RedirectToAction("Login", "Instructors");

            if (ModelState.IsValid)
            {
                _context.Add(book);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(book);
        }

        public IActionResult Edit(int? id)
        {
            if (!isInstructor())
                return RedirectToAction("Login", "Instructors");

            if (id == null)
            {
                return NotFound();
            }

            var book = _context.Books.Find(id);
            if (book == null)
            {
                return NotFound();
            }
            return View(book);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("Id,Name,ImagePath,Author,Shortcut,Category")] Book book)
        {
            if (!isInstructor())
                return RedirectToAction("Login", "Instructors");

            if (id != book.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(book);
                    _context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BookExists(book.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(book);
        }

        private bool BookExists(int id)
        {
            return _context.Books.Any(e => e.Id == id);
        }


        private bool isInstructor()
        {
            int.TryParse(_session.GetString("Type")?.ToString() ?? "0", out int type);
            return type == 2;
        }
    }
}
