using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntertShop.Data;
using IntertShop.Models;

namespace InternetShop.DataAccess.Repository.Categories
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public readonly ApplicationDbContext _context;
        public CategoryRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
        public void Save()
        {
            _context.SaveChanges();
        }

    }
}
