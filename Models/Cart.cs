using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BookShop.Models
{
    public class Cart
    {
        [Key]
        public int CartID { get; set; }

        [ForeignKey("CartItem")]
        public int UserID { get; set; }//OIUYTRFD
        public User User { get; set; }

        // Navigation property for CartItems
        public List<CartItem> CartItems { get; set; }
    }
}
