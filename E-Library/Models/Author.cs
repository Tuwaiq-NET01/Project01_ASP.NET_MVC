using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Library.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int BooksWritten { get; set; }
        public string About { get; set; }
    }
}
