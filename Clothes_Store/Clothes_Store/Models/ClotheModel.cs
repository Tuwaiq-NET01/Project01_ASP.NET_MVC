using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clothes_Store.Models
{
    public class ClotheModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string img { get; set; }
        public decimal Price { get; set; }

        public string gender { get; set; }

    }
}
