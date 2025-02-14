using Microsoft.EntityFrameworkCore;
using WebAPI1.Model;

namespace WebAPI1.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<StudentEntity> Students { get; set; }
    }
}
