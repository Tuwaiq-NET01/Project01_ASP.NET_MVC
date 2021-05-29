using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }

        public int AuthorId { get; set; }
        public Author Author { get; set; }



    }
}
