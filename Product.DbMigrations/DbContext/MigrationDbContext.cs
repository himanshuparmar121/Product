using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Product.Schema.Models;

namespace Product.DbMigrations
{
    public class MigrationDbContext : DbContext
    {
        public MigrationDbContext(DbContextOptions<MigrationDbContext> options)
        : base(options)
        {
        }

        DbSet<Item> Items { get; set; }
        DbSet<ItemObjects> ItemObjects { get; set; }
    }
}
