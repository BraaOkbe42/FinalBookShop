using Microsoft.AspNetCore.Mvc;

namespace BookShop.Controllers
{
    public class ShoppingCart : Controller
    {
        public IActionResult cart()
        {
            return View();
        }
    }
}
