using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodMVC.Models
{
    public class Recipe
    {
        public int id { get; set; }
        public string RecipeName { get; set; }
        public string ChefName { get; set; }
        public string pic { get; set; }
        public string dishImage { get; set; }
        public string country { get; set; }
        public string ingredients { get; set; }
    }
}
