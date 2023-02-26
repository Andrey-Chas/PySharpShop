using PySharpShopApplication.Models;
using System.Threading.Tasks;

namespace PySharpShopApplication.Services.Interfaces
{
    public interface ICategoryRepository : IRepository<Category>
    {
        Task<Category> GetByCategoryIdAsync(long? categoryId);
    }
}
