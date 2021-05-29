namespace DotNetProject1.Models
{
    public class BooksModel
    {
        public int id; 
        public string description;
        public string author;
        public double price;
        public string image;
        
        public BooksModel(int id, string description, string author, double price, string image)
        {
            this.id = id;
            this.description = description;
            this.author = author;
            this.price = price;
            this.image = image;
        }
    }
}