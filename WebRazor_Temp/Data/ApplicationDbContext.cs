using WebRazor_Temp.Models;
using Microsoft.EntityFrameworkCore;

namespace WebRazor_Temp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categorie { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                    new Category { Id = 3, Name = "Maths", DisplayOrder = 2, ProductName = "Math Textbook" },
                    new Category { Id = 4, Name = "History", DisplayOrder = 4, ProductName = "History Guide" },
                    new Category { Id = 5, Name = "History", DisplayOrder = 3, ProductName = "World History" }

                );
        }

    }
}
