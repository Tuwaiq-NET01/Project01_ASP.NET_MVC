using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class PlacesDbContext : DbContext
    {// ctor constructor
        // prop 
        public PlacesDbContext(DbContextOptions<PlacesDbContext> options): base (options)
        {
            

        }

        public DbSet<Place> Place { set; get; }
        public DbSet<Address> Address { set; get; }


    }
}
