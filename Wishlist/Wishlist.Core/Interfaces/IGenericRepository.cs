using System.Collections.Generic;

namespace Wishlist.Core.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        void Insert(T entity);
        IEnumerable<T> GetAll();
    }
}
