using System.ComponentModel.DataAnnotations;

namespace BookShop.Models
{
    public class User
    {
        [Key]
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; } // Consider storing hashed passwords

        // Navigation property for related Cart
        public Cart Cart { get; set; }
        // Navigation property for related Orders
        public ICollection<Order> Orders { get; set; }
    }
}
