using IntertShop.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace InternetShop.DataAccess.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<T> _dbSet;

        public Repository(ApplicationDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public void Add(T entity)
        {
            _dbSet.Add(entity);
        }

        public void Delete(T entity)
        {
           _dbSet.Remove(entity);
        }

        public IEnumerable<T> GetAll()
        {
           return _dbSet.ToList();
        }

        public T GetById(Expression<Func<T, bool>> filter)
        {
            return _dbSet.FirstOrDefault(filter);
        }

        public void Update(T entity)
        {
            _dbSet.Update(entity);
        }
    }
}
