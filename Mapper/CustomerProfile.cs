using apiOnGo.DTO;
using apiOnGo.Models;
using AutoMapper;

namespace apiOnGo.Mapper
{
    public class CustomerProfile: Profile
    {
        public CustomerProfile()
        {
            CreateMap<CustomerDTO, Customer>()
                .ForMember(dest => dest.Id, opt => opt.Ignore());

            CreateMap<Customer, CustomerDTO>();
        }

    }
}
