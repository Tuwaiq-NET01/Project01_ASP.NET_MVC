using System;
using System.Collections.Generic;

namespace NatureEscapes.Models
{
    public class ProductModel
    {

        public int ID { get; set; }

        public string Name { get; set; }

        public float Price { get; set; }

        public string Image { get; set; }

        public string Description { get; set; }

        public float Size { get; set; }
        public ProductModel()
        {

        }
    }
}
