using BookShop.Models;
using BookShop.ViewModels;
using BookStore.Data;
using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;


namespace BookShop.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<User> signInManager;
        private readonly Microsoft.AspNetCore.Identity.UserManager<User> userManager;
        private readonly BookStoreContext _context;
        public AccountController(SignInManager<User> signInManager, Microsoft.AspNetCore.Identity.UserManager<User> userManager, BookStoreContext context)
        {
            this.signInManager = signInManager;
            this.userManager = userManager;
            this._context = context;
        }


        public IActionResult login()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> login(LoginVM model)
        {
            if (ModelState.IsValid)
            {
                Console.WriteLine(model.Password!);
                var result = await signInManager.PasswordSignInAsync(model.UserName!, model.Password!, false,false);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError("", "Inavalid login attempt!");
                return View(model);

            }
            return View(model);
        }

        public async Task<IActionResult> Register(RegisterVM model)
        {
            if (ModelState.IsValid)
            {
                User user = new User
                {
                    UserName = model.UserName, // This sets the inherited UserName property
                    Email = model.Email,
                    EmailConfirmed = true,
                    LockoutEnabled = true,
                    PhoneNumberConfirmed = true,
                    TwoFactorEnabled = true
                    // Do not set UserID or PasswordHash here; Identity will handle these.
                };

                var result = await userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    await signInManager.SignInAsync(user, false);
                    return RedirectToAction("Index", "Home");
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }

            return View(model);
        }

        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction(nameof(HomeController.Index));   
        }

        public IActionResult reset()
        {
            return View();
        }
    }
}
