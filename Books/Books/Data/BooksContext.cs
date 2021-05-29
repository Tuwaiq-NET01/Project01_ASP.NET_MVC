using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace Books.Data
{
    public class BooksContext : DbContext
    {
        public BooksContext (DbContextOptions<BooksContext> options)
            : base(options)
        {
        }

        public DbSet<MvcMovie.Models.Author> Author { get; set; }

        public DbSet<MvcMovie.Models.Book> Book { get; set; }
    }
}
