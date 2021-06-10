using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NadaMVC.Models
{
    public class BookModel
    {
        public int BookId { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public int Published { get; set; }
        public string image { get; set; }

        public BookModel(int BookId, string Author, string Title, int Published, string image)
        {
            this.BookId = BookId;
            this.Author = Author;
            this.Title = Title;
            this.Published = Published;
            this.image = image;
        }
    }
}
