using Microsoft.EntityFrameworkCore;
using RecipeApplicarion.Entity;

namespace RecipeApplicarion
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
    }
}
