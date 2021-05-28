using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project01.Models
{
    public class ItemModel
    {
        //Item Id
        public int ID { get; set; }
        //Item name
        public string Name { get; set; }
        // Item Price
        public decimal Price { get; set; }
        //Item Quantity the user well request
        public int Quantity { get; set; }
        //Item Image
        public string Image { get; set; }
        //Item Description
        public string Description { get; set; }
        //Item type : Fruit or Vegetable
        public string Type { get; set; }
    }
}
