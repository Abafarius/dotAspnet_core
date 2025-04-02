using InternetShop.DataAccess.Repository.Categoryes;
using InternetShop.DataAccess.Repository.Products;

namespace InternetShop.DataAccess.Repository
{
    public interface IUnitOfWork
    {
        ICategoryRepository CategoryRepository { get; }
        IProductRepository ProductRepository { get; }
        void Save();
    }
}
