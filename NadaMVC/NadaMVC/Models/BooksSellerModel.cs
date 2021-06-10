using System;
namespace NadaMVC.Models
{
    public class BooksSellerModel
    {
        public int SellerId { get; set; }
        public string Name { get; set; }
        public string image { get; set; }

        public BooksSellerModel(int SellerId, string Name, string image)
        {
            this.SellerId = SellerId;
            this.Name = Name;
            this.image = image;
           
        }
    }
}
