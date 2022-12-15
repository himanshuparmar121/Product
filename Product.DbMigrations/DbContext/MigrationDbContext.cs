using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Product.Data;
using Product.Schema.Models;

namespace Product.DbMigrations
{
    public class MigrationDbContext : DbContext
    {
        MigrationDbContext migrationDbContext;
        public MigrationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
            migrationDbContext = new MigrationDbContext(options);   
        }

        public DbSet<Item> Items { get; set; }
        public DbSet<ItemObjects> ItemObjects { get; set; }
    }
}
