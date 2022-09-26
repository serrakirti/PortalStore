using AutoMapper;
using PortalStore.DTOs;
using PortalStore.CoreLayer.Model;

namespace PortalStore.API.Mapping
{
    public class MapProfiler : Profile
    {
        public MapProfiler()
        {
            CreateMap<Adress, AdressDto>();
            CreateMap<AdressDto, Adress>();

            CreateMap<Category, CategoryDto>();
            CreateMap<CategoryDto, Category>();

            CreateMap<Product, ProductDto>();
            CreateMap<ProductDto, Product>();

            CreateMap<Order, OrderDto>();
            CreateMap<OrderDto, Order>();

            CreateMap<OrderItem, OrderItemDto>();
            CreateMap<OrderItemDto, OrderItem>();

            CreateMap<Customer, CustomerDto>();
            CreateMap<CustomerDto, Customer>();

            CreateMap<Adress, AdressWithOrdersDto>();
            CreateMap<AdressWithOrdersDto, Adress>();

            CreateMap<Category, CategoryWithProdutsDto>();
            CreateMap<CategoryWithProdutsDto, Category>();

            CreateMap<Customer, CustomerWithOrdersDto>();
            CreateMap<CustomerWithOrdersDto, Customer>();

            CreateMap<Order, OrderWithOrderItemDto>();
            CreateMap<OrderWithOrderItemDto, Order>();

            CreateMap<Product, ProductWithOrderItemDto>();
            CreateMap<ProductWithOrderItemDto, Product>();

        }
    }
}
