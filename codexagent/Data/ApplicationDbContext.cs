using Microsoft.EntityFrameworkCore;
using codexagent.Models;

namespace codexagent.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Students { set; get; }
    }
}
