using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wishlist.Core.Domain;
using Wishlist.Core.Interfaces;

namespace Wishlist.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        readonly CompanyDbContext _context;

        public UnitOfWork()
        {
            _context = new CompanyDbContext();
        }

        private bool _disposed;
        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            _disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }     
        
        public void Save()
        {
            _context.SaveChanges();
        }

        public IGenericRepository<WishListItem> WishListItemRepository
        {
            get { return new GenericRepository<WishListItem>(_context); }
        }
    }
}
