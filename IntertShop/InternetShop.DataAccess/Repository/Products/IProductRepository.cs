using InternetShop.Models.Models;

namespace InternetShop.DataAccess.Repository.Products
{
    public interface IProductRepository : IRepository<Product>
    {
        void Save();
    }
}
