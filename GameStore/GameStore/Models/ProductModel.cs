using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStore.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Released { get; set; }
        public string Img { get; set; }
        public string Rating { get; set; }
        public string RatingsCount { get; set; }
        public string Color { get; set; }
        public string[] ScreenShots { get; set; }
        
    }
}
