using AutoMapper;

namespace AuraTicket.Services.ShoppingBasket.Profiles
{
    public class EventProfile: Profile
    {
        public EventProfile()
        {
            CreateMap<Entities.Event, Models.Event>().ReverseMap();
        }
    }
}
