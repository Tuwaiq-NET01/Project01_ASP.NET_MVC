using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project01.NET.Models
{
    public class BookModel
    {
        public int id { get; set; }
        public string bookName { get; set; }
        public string authorName { get; set; }
        public string publisher { get; set; }
        public int releaseYear { get; set; }
        public double price { get; set; }
        public string image { get; set; }

        public BookModel(int id, string book, string author, string pub, int year, double price, string img)
        {
            this.id = id;
            this.bookName = book;
            this.authorName = author;
            this.publisher = pub;
            this.releaseYear = year;
            this.price = price;
            this.image = img;
        }

    }
}
