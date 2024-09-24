using System;
using System.Net.Http;
using System.Threading.Tasks;
using AuraTicket.Services.ShoppingBasket.Entities;
using AuraTicket.Services.ShoppingBasket.Extensions;

namespace AuraTicket.Services.ShoppingBasket.Services
{
    public class EventCatalogService : IEventCatalogService
    {
        private readonly HttpClient client;

        public EventCatalogService(HttpClient client)
        {
            this.client = client;
        }

        public async Task<Event> GetEvent(Guid id)
        {
            var response = await client.GetAsync($"/api/events/{id}");
            return await response.ReadContentAs<Event>();
        }
    }
}
