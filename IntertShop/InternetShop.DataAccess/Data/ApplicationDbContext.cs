using InternetShop.Models;
using InternetShop.Models.Models;
using Microsoft.EntityFrameworkCore;

namespace InternetShop.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :
            base(options) { Database.EnsureCreated(); }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                    new Category { Id = 1, Name = "Action", OrderDisplay = 1 },
                    new Category { Id = 2, Name = "Sci-Fi", OrderDisplay = 2 },
                    new Category { Id = 3, Name = "History", OrderDisplay = 3 }
                );

            modelBuilder.Entity<Product>().HasData(
                    new Product
                    {
                        Id = 1,
                        Title = "C# in Depth",
                        Description = "Guide to C#",
                        Author = "Jon Skeet",
                        Price = 5999.00,
                        CategoryId = 1,
                    },
                    new Product
                    {
                        Id = 2,
                        Title = "Clean Code",
                        Description = "Best practies for writing code",
                        Author = "Robert Martin",
                        Price = 9999.00,
                        CategoryId = 2,
                    }
                );
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
