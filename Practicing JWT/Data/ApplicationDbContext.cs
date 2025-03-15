using Microsoft.EntityFrameworkCore;
using Practicing_JWT.Model;

namespace Practicing_JWT.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Authentication> Auth { get; set; }
        public DbSet<Order> Order { get; set; }
    }
}
