using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productify.Domain.Entities;

namespace Productify.Persistence.Context
{
    public class ProductifyDbContext : DbContext
    {
        public DbSet <Product> Products { get; set;  }
        public DbSet <Product> WishList { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("ProductifyDbElif");
        }

    }
}
