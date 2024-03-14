using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BookShop.Models
{
    public class CartItem
    {
        //ORDERS USERID CARTID TOTAL
        [Key]
        public int CartItemID { get; set; }
       

        [ForeignKey("Cart")]
        public int CartID { get; set; }//KJHGFDFGHJ

        [ForeignKey("Book")]
        public int BookID { get; set; }//KJHGFD
        public int Quantity { get; set; }//HGFDFGHJ

        public Cart Cart { get; set; }
        public Book Book { get; set; }//LKJHGFDFGH
    }
}
