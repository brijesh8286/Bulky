using Bulky.Models;
using Microsoft.EntityFrameworkCore;

namespace Bulky.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
        
        }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(           
                new Category { Id = 4, Name = "Maths", DisplayOrder = 4 },
                new Category { Id = 5, Name = "History", DisplayOrder = 5 },
                new Category { Id = 6, Name = "History", DisplayOrder = 6 }
                );
        }

    }
}
