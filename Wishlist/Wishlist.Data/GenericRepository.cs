using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Wishlist.Core.Interfaces;

namespace Wishlist.Data
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class 
    {
        readonly CompanyDbContext _context;
        readonly DbSet<T> _dbSet;

        public GenericRepository(CompanyDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public void Insert(T entity)
        {
            _dbSet.Add(entity);
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet.AsEnumerable();
        }
    }
}
