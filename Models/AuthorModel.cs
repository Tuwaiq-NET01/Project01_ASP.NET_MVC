using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project01.NET.Models
{
    public class AuthorModel
    {
        public string name { get; set; }
        public int birthYear { get; set; }
        public int numOfBooks { get; set; }
        
        public AuthorModel(string name, int year, int numOfBooks)
        {
            this.name = name;
            this.birthYear = year;
            this.numOfBooks = numOfBooks;
        }
    }
}
