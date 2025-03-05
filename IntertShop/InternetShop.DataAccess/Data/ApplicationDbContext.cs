using IntertShop.Models;
using Microsoft.EntityFrameworkCore;

namespace IntertShop.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :
            base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                    new Category { Id = 1, Name = "Action", OrderDisplay = 1 },
                    new Category { Id = 2, Name = "Sci-Fi", OrderDisplay = 2 },
                    new Category { Id = 3, Name = "History", OrderDisplay = 3 }
                );
        }
        public DbSet<Category> Categories { get; set; }
    }
}
