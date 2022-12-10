using Microsoft.EntityFrameworkCore;
using Product.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.DbMigrations
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }

        DbSet<Item> Items { get; set; }
        DbSet<ItemObjects> ItemObjects { get; set; }

    }
}
