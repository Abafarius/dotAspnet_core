using InternetShop.Data;
using InternetShop.Models.Models;
using Microsoft.EntityFrameworkCore;

namespace InternetShop.DataAccess.Repository.Products
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly ApplicationDbContext _context;

        public ProductRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public IEnumerable<Product> GetAllWithCategories()
        {
            return _context.Products.Include(p => p.Category).ToList();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
