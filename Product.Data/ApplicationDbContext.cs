using Microsoft.EntityFrameworkCore;
using Product.Schema.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.DbMigrations.DBContext
{
    public class ApplicationDbContext : DbContext
    {
        ApplicationDbContext applicationDb;
        public ApplicationDbContext(DbContextOptions<MigrationDbContext> options)
        : base(options)
        {
            applicationDb = new ApplicationDbContext(options);
        }
    }
}
