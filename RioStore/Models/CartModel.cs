using System;
namespace RioStore.Models
{
    public class ProductsInCart
    {
        public int productId { get; set; }
        public int quantity { get; set; }
    }
    public class Cart
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime Date { get; set; }
        public System.Collections.Generic.List<ProductsInCart> Products { get; set; }
    }
}