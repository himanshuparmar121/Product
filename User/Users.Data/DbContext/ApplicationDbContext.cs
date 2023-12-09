using Microsoft.EntityFrameworkCore;

namespace Users.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }

        public DbSet<Schema.Models.User> Users { get; set; }
        public DbSet<Schema.Models.UserDetail> UserDetails { get; set; }

    }
}
