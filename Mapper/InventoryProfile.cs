using apiOnGo.DTO;
using apiOnGo.Models;
using AutoMapper;

namespace apiOnGo.Mapper
{
    public class InventoryProfile : Profile
    {

        public InventoryProfile() {
            CreateMap<Inventory, InventoryDTO>();
            CreateMap<Inventory, Inventory>()
                .ForMember(dest => dest.Id, opt => opt.Ignore());
            
        }   
    }
}
