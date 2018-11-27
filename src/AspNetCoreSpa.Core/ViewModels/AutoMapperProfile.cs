using MyCommunity.Core.Entities;
using AutoMapper;

namespace MyCommunity.Core.ViewModels
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Customer, CustomerViewModel>()
                .ReverseMap();

            CreateMap<Product, ProductViewModel>()
                .ReverseMap();

            CreateMap<ProductCategory, ProductCategoryViewModel>()
                .ReverseMap();

            CreateMap<Order, OrderViewModel>()
                .ReverseMap();
        }
    }
}
