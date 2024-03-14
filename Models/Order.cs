namespace BookShop.Models
{
    public class Order
    {
        //מחיר כמות CARTITEMID
        public int OrderID { get; set; }
        public int UserID { get; set; }//olpkpkp;oo
        public decimal TotalPrice { get; set; }
        public DateTime OrderDate { get; set; }

        public User User { get; set; }//pojipjo
        // Navigation property for OrderDetails
    }
}
