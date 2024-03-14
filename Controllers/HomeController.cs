using BookShop.Models;
using BookStore.Data;
using DocumentFormat.OpenXml.InkML;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Threading.Tasks;

namespace BookShop.Controllers
{

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly BookStoreContext _context;

        public HomeController(ILogger<HomeController> logger, BookStoreContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var books = await _context.Books.ToListAsync();
            return View(books);
        }

        public async Task<IActionResult> ShowBook()
        {
            var books = await _context.Books.ToListAsync();
            return View(books);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }



        //public ActionResult ShowBook(int id)
        //{
        //    // Fetch the book details based on the id
        //    var book = GetBookById(id);

        //    // Pass the book details to the view
        //    return View(book);
        //}

        //// Dummy method to retrieve book details
        private Book GetBookById(int id)
        {
            // Logic to fetch book details from your data source (database, etc.)
            // Replace this with your actual data retrieval logic
            return _context.Books.FirstOrDefault(b => b.BookID == id);
        }


        [HttpGet]
        [Route("Home/ShowBook/{id}", Name = "ShowBookById")]
        public ActionResult ShowBook(int id)
        {
            // Fetch the book details based on the id
            var book = GetBookById(id);

            // Pass the book details to the view
            return View(book);
        }

        //[HttpGet]
        //[Route("Home/ShowBook/{id}", Name = "ShowBookById")]
        //public ActionResult ShowBook(int id)
        //{
        //    // Fetch the book details based on the id
        //    var book = GetBookById(id);

        //    // Pass the book details to the view
        //    return View(book);
        //}


    }


}
