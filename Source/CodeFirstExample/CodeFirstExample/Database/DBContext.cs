using CodeFirstExample.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstExample.Database
{
    public class CodeFirstDbContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=CodeFirstExample;Trusted_Connection=False;User ID=sa;Password=Password1234!");
        }
    }
}
