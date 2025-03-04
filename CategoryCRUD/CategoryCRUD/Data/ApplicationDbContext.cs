using Microsoft.EntityFrameworkCore;
using CategoryCRUD.Models;

namespace CategoryCRUD.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Category> Categories { get; set; }
    }
}
