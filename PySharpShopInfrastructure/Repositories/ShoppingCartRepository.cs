using Microsoft.EntityFrameworkCore;
using PySharpShopApplication.Models;
using PySharpShopApplication.Services.Interfaces;
using PySharpShopInfrastructure.Database.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PySharpShopInfrastructure.Repositories
{
    public class ShoppingCartRepository : IShoppingCartRepository
    {
        private readonly DatabaseContext _context;
        public ShoppingCartRepository(DatabaseContext context)
        {
            _context = context;
        }
        public Task DeleteAsync(ShoppingCart entity)
        {
            _context.ShoppingCarts.Remove(entity);
            return Task.CompletedTask;
        }

        public async Task<ShoppingCart> GetAsync(long? id)
        {
            return await _context.ShoppingCarts.AsQueryable()
                .Where(e => e.Id == id)
                .SingleAsync();
        }

        public async Task<IEnumerable<ShoppingCart>> GetAsync()
        {
            return await _context.ShoppingCarts.AsQueryable()
                .ToListAsync();
        }

        public async Task<ShoppingCart> GetByShoppingCartIdAsync(long? shoppingCartId)
        {
            return await _context.ShoppingCarts.AsQueryable()
                .Where(e => e.Id == shoppingCartId)
                .FirstOrDefaultAsync();
        }

        public async Task<long?> SaveAsync(ShoppingCart entity)
        {
            await _context.ShoppingCarts.AddAsync(entity);
            return entity.Id;
        }

        public Task UpdateAsync(ShoppingCart entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            return Task.CompletedTask;
        }
    }
}
