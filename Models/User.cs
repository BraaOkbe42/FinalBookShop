using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace BookShop.Models
{
    public class User: IdentityUser
    {
        [Key]

        public int UserID { get; set; }
        // Navigation property for related Cart
        public List<CartItem> CartItems { get; set; }

         
    }
}
