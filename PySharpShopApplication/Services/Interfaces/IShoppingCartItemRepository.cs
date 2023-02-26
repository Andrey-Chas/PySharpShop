using PySharpShopApplication.Models;
using System.Threading.Tasks;

namespace PySharpShopApplication.Services.Interfaces
{
    public interface IShoppingCartItemRepository : IRepository<ShoppingCartItem>
    {
        Task<ShoppingCartItem> GetByShoppingCartAsync(long? shoppingCartId);
    }
}
