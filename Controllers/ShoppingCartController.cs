using BookShop.Models;
using BookStore.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookShop.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly BookStoreContext _context;


        public ShoppingCartController()
        {
            this._context = _context;
        }
        public  IActionResult cart()
        {
            return View();
        }

        //public async Task<IActionResult> cart()
        //{

        //    return View();
        //}

/*        public async Task<IActionResult> BuyMeNow(int id)
        {
            var book = GetBookById(id);
            return View(book);

        }
*/
 


/*
        private Book GetBookById(int id)
        {
            // Logic to fetch book details from your data source (database, etc.)
            // Replace this with your actual data retrieval logic
            return _context.Books.FirstOrDefault(b => b.BookID == id);
        }


        [HttpGet]
        [Route("ShoppingCart/Cart/{id}", Name = "ShowBookById")]
        public ActionResult ShowBook(int id)
        {
            // Fetch the book details based on the id
            var book = GetBookById(id);

            // Pass the book details to the view
            return View(book);
        }
*/








        /*        [HttpPost]
        */        /* public IActionResult AddToCart(int id)
                 {
                     // Fetch the book details based on the id
                     var book = GetBookById(id);

                     // Add the book to the cart (You need to implement your cart logic here)

                     // For demonstration purposes, you can store the book ID in session
                     var cartItems = HttpContext.Session.Get<List<int>>("CartItems") ?? new List<int>();
                     cartItems.Add(id);
                     HttpContext.Session.Set("CartItems", cartItems);

                     return RedirectToAction("Index", "Home");
                 }

                 private Book GetBookById(int id)
                 {
                     return _context.Books.FirstOrDefault(b => b.BookID == id);
                 }*/
    }
}
