using System;
using System.Threading.Tasks;
using AuraTicket.Services.ShoppingBasket.Entities;

namespace AuraTicket.Services.ShoppingBasket.Repositories
{
    public interface IEventRepository
    {
        void AddEvent(Event theEvent);
        Task<bool> EventExists(Guid eventId);
        Task<bool> SaveChanges();
    }
}