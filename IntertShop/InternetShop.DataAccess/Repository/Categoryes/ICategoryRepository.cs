using InternetShop.Models;

namespace InternetShop.DataAccess.Repository.Categoryes
{
    public interface ICategoryRepository : IRepository<Category>
    {
        void Save();
    }
}
