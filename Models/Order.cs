﻿namespace BookShop.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public int UserID { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime OrderDate { get; set; }

        public User User { get; set; }
        // Navigation property for OrderDetails
    }
}
