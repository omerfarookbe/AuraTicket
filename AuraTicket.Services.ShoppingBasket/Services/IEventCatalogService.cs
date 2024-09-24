using System;
using System.Threading.Tasks;
using AuraTicket.Services.ShoppingBasket.Entities;

namespace AuraTicket.Services.ShoppingBasket.Services
{
    public interface IEventCatalogService
    {
        Task<Event> GetEvent(Guid id);
    }
}