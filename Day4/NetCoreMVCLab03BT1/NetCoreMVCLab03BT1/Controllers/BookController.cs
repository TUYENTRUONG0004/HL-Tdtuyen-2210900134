using Microsoft.AspNetCore.Mvc;
using NetCoreMVCLab03.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace NetCoreMVCLab03.Controllers
{
    public class BookController : Controller
    {
        protected Book book = new Book();

        public IActionResult Index()
        {
            // Danh sách thể loại và tác giả
            ViewBag.authors = book.GetBookList().Select(a => new SelectListItem
            {
                Value = a.AuthorId.ToString(),
                Text = a.AuthorId.ToString()
            }).ToList();

            ViewBag.genres = book.GetBookList().Select(g => new SelectListItem
            {
                Value = g.GenreId.ToString(),
                Text = g.GenreId.ToString()
            }).ToList();

            var books = book.GetBookList();
            return View(books);
        }

        public IActionResult Create()
        {
            ViewBag.genres = book.GetBookList().Select(g => new SelectListItem
            {
                Value = g.GenreId.ToString(),
                Text = g.GenreId.ToString()
            }).ToList();

            ViewBag.authors = book.GetBookList().Select(a => new SelectListItem
            {
                Value = a.AuthorId.ToString(),
                Text = a.AuthorId.ToString()
            }).ToList();

            Book model = new Book();
            return View(model);
        }

        [HttpPost]
        public IActionResult Create(Book book)
        {
            if (ModelState.IsValid)
            {
                var books = Book.GetBookList();
                book.Id = books.Count + 1;
                books.Add(book);
                return RedirectToAction("Index");
            }
            return View(book);
        }
    }
}