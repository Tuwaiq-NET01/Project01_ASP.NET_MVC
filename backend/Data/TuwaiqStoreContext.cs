using TuwaiqStoreBackend.Models;
using Microsoft.EntityFrameworkCore;

namespace TuwaiqStoreBackend.Data
{
    public class TuwaiqStoreContext : DbContext
    {
        public TuwaiqStoreContext(DbContextOptions<TuwaiqStoreContext> options) : base(options)
        {

        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}