using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Users.Data;
using Users.Schema.Models;

namespace Users.DbMigrations
{
    public class MigrationDbContext : DbContext
    {
        MigrationDbContext migrationDbContext;
        public MigrationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
            migrationDbContext = new MigrationDbContext(options);
        }

        public DbSet<User> Users { get; set; }
        public DbSet<UserDetail> UserDetails { get; set; }
    }
}
