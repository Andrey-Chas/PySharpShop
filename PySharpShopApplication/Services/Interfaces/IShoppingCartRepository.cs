using PySharpShopApplication.Models;
using System.Threading.Tasks;

namespace PySharpShopApplication.Services.Interfaces
{
    public interface IShoppingCartRepository : IRepository<ShoppingCart>
    {
        Task<ShoppingCart> GetByShoppingCartIdAsync(long? shoppingCartId);
    }
}
