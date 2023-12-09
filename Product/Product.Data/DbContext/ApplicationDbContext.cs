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

        public DbSet<Schema.Models.Item> Items { get; set; }
        public DbSet<Schema.Models.ItemObjects> ItemObjects { get; set; }
    }
}
