using System;
using Wishlist.Core.Domain;

namespace Wishlist.Core.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<WishListItem> WishListItemRepository { get; }
        void Save();
    }
}
