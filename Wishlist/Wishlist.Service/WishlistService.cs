using System;
using System.Collections.Generic;
using Wishlist.Core.Domain;
using Wishlist.Core.Interfaces;

namespace Wishlist.Service
{
    public class WishlistService : IWishlistService
    {
        readonly IUnitOfWork _unitOfWork;

        public WishlistService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void AddWishlistItem(string description, int quantity)
        {
            var wishListItem = new WishListItem
                {
                    Description = description,
                    Quantity = quantity
                };

            _unitOfWork.WishListItemRepository.Insert(wishListItem);
            _unitOfWork.Save();
        }

        public IList<WishListItem> GetAllWishlistItems()
        {
            return (List<WishListItem>) _unitOfWork.WishListItemRepository.GetAll();
        }
    }
}
