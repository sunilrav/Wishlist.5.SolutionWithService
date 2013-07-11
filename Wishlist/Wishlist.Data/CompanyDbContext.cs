using System.Data.Entity;
using Wishlist.Core.Domain;

namespace Wishlist.Data
{
    public class CompanyDbContext : DbContext
    {
        public DbSet<WishListItem> WishListItems { get; set; }
    }
}
