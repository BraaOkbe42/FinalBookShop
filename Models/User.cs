using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace BookShop.Models
{
    public class User: IdentityUser
    {
        [Key]

        public int UserID { get; set; }
        // Navigation property for related Cart
        public Cart Cart { get; set; }
        // Navigation property for related Orders
        public ICollection<Order> Orders { get; set; }
    }
}
