using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        public IList<Book> Books { get; set; }


    }
}
