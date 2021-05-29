using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlowerShop.Models
{
    public class ReviewModel
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Comment { get; set; }
    }
}
