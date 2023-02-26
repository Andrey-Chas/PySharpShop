﻿using Microsoft.EntityFrameworkCore;
using PySharpShopApplication.Models;
using PySharpShopApplication.Services.Interfaces;
using PySharpShopInfrastructure.Database.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PySharpShopInfrastructure.Repositories
{
    public class ShoppingCartItemRepository : IShoppingCartItemRepository
    {
        private readonly DatabaseContext _context;
        public ShoppingCartItemRepository(DatabaseContext context)
        {
            _context = context;
        }
        public Task DeleteAsync(ShoppingCartItem entity)
        {
            _context.ShoppingCartItems.Remove(entity);
            return Task.CompletedTask;
        }

        public async Task<ShoppingCartItem> GetAsync(long? id)
        {
            return await _context.ShoppingCartItems.AsQueryable()
                .Where(e => e.Id == id)
                .SingleAsync();
        }

        public async Task<IEnumerable<ShoppingCartItem>> GetAsync()
        {
            return await _context.ShoppingCartItems.AsQueryable()
                .ToListAsync();
        }

        public async Task<ShoppingCartItem> GetByShoppingCartAsync(long? shoppingCartId)
        {
            return await _context.ShoppingCartItems.AsQueryable()
                .Where(e => e.ShoppingCartId == shoppingCartId)
                .FirstOrDefaultAsync();
        }

        public async Task<long?> SaveAsync(ShoppingCartItem entity)
        {
            await _context.ShoppingCartItems.AddAsync(entity);
            return entity.Id;
        }

        public Task UpdateAsync(ShoppingCartItem entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            return Task.CompletedTask;
        }
    }
}
