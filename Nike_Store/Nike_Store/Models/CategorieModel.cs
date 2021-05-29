using System;
namespace Nike_Store.Models
{
    public class CategorieModel
    {
        public int Id { set; get; }
        public string Categorie { set; get; }
        public string Img { set; get; }
    }
    public class MenProudctsModel
    {
        public int Id { set; get; }
        public string Type { set; get; }
        public int Size { set; get; }
        public decimal Price { set; get; }
        public string Img { set; get; }
    }
}
