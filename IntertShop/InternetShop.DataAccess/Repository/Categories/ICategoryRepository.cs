using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntertShop.Models;

namespace InternetShop.DataAccess.Repository.Categories
{
    public interface ICategoryRepository : IRepository<Category>
    {
        void Save();
    }
}
