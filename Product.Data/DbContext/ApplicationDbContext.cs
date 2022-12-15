using Microsoft.EntityFrameworkCore;
using Product.Schema.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }

        public DbSet<Item> Items { get; set; }
        public DbSet<ItemObjects> ItemObjects { get; set; }
    }
}
