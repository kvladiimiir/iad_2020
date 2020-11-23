using Microsoft.EntityFrameworkCore;

namespace EntityFramework
{
    public class BlogDbContext : DbContext
    {
        public BlogDbContext(DbContextOptions<BlogDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\\MSSQLLocalDB;Database=BlogProject;Trusted_Connection=True;");
        }
    }
}
