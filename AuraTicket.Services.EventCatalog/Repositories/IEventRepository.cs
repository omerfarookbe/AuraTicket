using System;
using AuraTicket.Services.EventCatalog.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AuraTicket.Services.EventCatalog.Repositories
{
    public interface IEventRepository
    {
        Task<IEnumerable<Event>> GetEvents(Guid categoryId);
        Task<Event> GetEventById(Guid eventId);
    }
}
