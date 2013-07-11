using System.Collections.Generic;
using Wishlist.Core.Domain;

namespace Wishlist.Core.Interfaces
{
    public interface IWishlistService
    {
        void AddWishlistItem(string description, int quantity);
        IList<WishListItem> GetAllWishlistItems();
    }
}
