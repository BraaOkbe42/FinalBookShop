using BookShop.Models;
using BookStore.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BookShop.Data
{
    public class Seed
    {
        public static void SeedData(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<BookStoreContext>();

                // Ensure the database is created.
                context.Database.EnsureCreated();

                // Seed Books
                if (!context.Books.Any())
                {
                    context.Books.AddRange(
                        new Book
                        {
                            BookID = 1,
                            Title = "The Great Gatsby",
                            Author = "F. Scott Fitzgerald",
                            Price = 10.99m,
                            StockQuantity = 50,
                            ImgUrl = "url_to_image",
                            description = "A classic piece of American literature."
                        },
                        new Book
                        {
                            BookID = 2,
                            Title = "1984",
                            Author = "George Orwell",
                            Price = 12.99m,
                            StockQuantity = 40,
                            ImgUrl = "url_to_image",
                            description = "A dystopian social science fiction novel and cautionary tale."
                        }
                    );
                    context.SaveChanges();

                }
                if (!context.Carts.Any())
                {
                    var carts = new List<Cart>()
                      {
                     new Cart { CartID = 1, UserID = 1 }, // Assuming UserID = 1 exists
                     new Cart { CartID = 2, UserID = 2 }  // Assuming UserID = 2 exists
                     };

                    context.Carts.AddRange(carts);
                    context.SaveChanges();

                }

                // Seed CartItems
                if (!context.CartItems.Any())
                {
                    context.CartItems.AddRange(
                        new CartItem { CartItemID = 1, CartID = 1, BookID = 1, Quantity = 2 },
                        new CartItem { CartItemID = 2, CartID = 1, BookID = 2, Quantity = 1 },
                        new CartItem { CartItemID = 3, CartID = 2, BookID = 2, Quantity = 3 }
                    );
                    context.SaveChanges();

                }

                // Seed Orders
                if (!context.Orders.Any())
                {
                    context.Orders.AddRange(
                        new Order { OrderID = 1, UserID = 1, TotalPrice = 21.98m, OrderDate = DateTime.Now.AddDays(-10) },
                        new Order { OrderID = 2, UserID = 2, TotalPrice = 38.97m, OrderDate = DateTime.Now.AddDays(-5) }
                    );
                    context.SaveChanges();

                }
                // Seed Users
                if (!context.Users.Any())
                {
                    context.Users.AddRange(
                        new User { UserID = 1, Username = "user1", Email = "user1@example.com", Password = "hashed_password1" },
                        new User { UserID = 2, Username = "user2", Email = "user2@example.com", Password = "hashed_password2" },
                        new User { UserID = 3, Username = "user3", Email = "user3@example.com", Password = "hashed_password3" },
                        new User { UserID = 4, Username = "user4", Email = "user4@example.com", Password = "hashed_password4" }
                    );
                    context.SaveChanges();
                }




                // Continue with seeding for Users, Cart, CartItems, and Orders
                // Ensure each entity is checked for existing data before seeding to avoid duplicates.

                context.SaveChanges();
            }
        }

    }
}

