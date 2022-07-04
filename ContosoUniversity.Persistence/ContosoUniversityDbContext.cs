using ContosoUniversity.Models.Subject;
using Microsoft.EntityFrameworkCore;

namespace ContosoUniversity.Persistence
{
    public class ContosoUniversityDbContext : DbContext
    {
        public ContosoUniversityDbContext(DbContextOptions<ContosoUniversityDbContext> options) : base(options)
        {
        }

        public DbSet<Subject> Subjects { get; set; }
    }
}
