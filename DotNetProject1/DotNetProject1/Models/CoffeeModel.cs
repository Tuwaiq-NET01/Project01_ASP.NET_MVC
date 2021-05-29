namespace DotNetProject1.Models
{
    public class CoffeeModel
    {
        public int id; 
        public string description;
        public int portionSize;
        public double price;
        public string image;
        
        public CoffeeModel(int id, string description, int portionSize, double price, string image)
        {
            this.id = id;
            this.description = description;
            this.portionSize = portionSize;
            this.price = price;
            this.image = image;
        }
    }
}