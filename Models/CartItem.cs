using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BookShop.Models
{
    public class CartItem
    {
        [Key]
        public int CartItemID { get; set; }

        [ForeignKey("Cart")]
        public int CartID { get; set; }

        [ForeignKey("Book")]
        public int BookID { get; set; }
        public int Quantity { get; set; }

        public Cart Cart { get; set; }
        public Book Book { get; set; }
    }
}
