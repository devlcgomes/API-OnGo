using apiOnGo.DTO;
using apiOnGo.Models;
using AutoMapper;

namespace apiOnGo.Mapper
{
    public class ProductProfile: Profile
    {

        public ProductProfile() {
            CreateMap<Product, ProductDTO>();
            CreateMap<ProductDTO, Product>()
                .ForMember(dest => dest.Id, opt => opt.Ignore());
        }
    }
}
