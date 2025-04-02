using InternetShop.Data;
using InternetShop.DataAccess.Repository.Categoryes;
using InternetShop.DataAccess.Repository.Products;

namespace InternetShop.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public ICategoryRepository CategoryRepository { get; init; }
        public IProductRepository ProductRepository { get; init; }

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            CategoryRepository = new CategoryRepository(context);
            ProductRepository = new ProductRepository(context);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
