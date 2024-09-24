using AutoMapper;

namespace AuraTicket.Services.EventCatalog.Profiles
{
    public class CategoryProfile: Profile
    {
        public CategoryProfile()
        {
            CreateMap<Entities.Category, Models.CategoryDto>().ReverseMap();
        }
    }
}
