using PySharpShopApplication.Models;
using System.Threading.Tasks;

namespace PySharpShopApplication.Services.Interfaces
{
    public interface IPriceRepository : IRepository<Price>
    {
        Task<Price> GetByProductAsync(long? productId);
    }
}
