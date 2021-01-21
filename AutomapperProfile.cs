using AutoMapper;

using react_project.DTO.Order;
using react_project.DTO.Product;
using react_project.Models;

namespace react_project
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<Product, GetProductDTO>();
            CreateMap<GetProductDTO, Product>();

            CreateMap<Order, GetOrderDTO>();
            CreateMap<GetOrderDTO, Order>();
        }
        
    }
}