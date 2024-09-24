﻿using AuraTicket.Services.ShoppingBasket.DbContexts;
using AuraTicket.Services.ShoppingBasket.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuraTicket.Services.ShoppingBasket.Repositories
{
    public class BasketRepository : IBasketRepository
    {
        private readonly ShoppingBasketDbContext _shoppingBasketDbContext;

        public BasketRepository(ShoppingBasketDbContext shoppingBasketDbContext)
        {
            _shoppingBasketDbContext = shoppingBasketDbContext;
        }         

        public async Task<Basket> GetBasketById(Guid basketId)
        {
            return await _shoppingBasketDbContext.Baskets.Include(sb => sb.BasketLines)
                .Where(b => b.BasketId == basketId).FirstOrDefaultAsync();
        }

        public async Task<bool> BasketExists(Guid basketId)
        {
            return await _shoppingBasketDbContext.Baskets
                .AnyAsync(b => b.BasketId == basketId);
        }

        public void AddBasket(Basket basket)
        {
            _shoppingBasketDbContext.Baskets.Add(basket);
        }

        public async Task<bool> SaveChanges()
        {
            return (await _shoppingBasketDbContext.SaveChangesAsync() > 0);
        }
    }
}
