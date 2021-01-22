using AutoMapper;
using react_project.DTO.Order;
using react_project.DTO.OrderDetails;
using react_project.DTO.Product;
using react_project.Models;

namespace react_project
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<Product, GetProductDTO>();
            CreateMap<AddProductDTO, Product>();

            CreateMap<Order, GetOrderDTO>();
            CreateMap<AddOrderDTO, Order>();

            CreateMap<OrderDetail, OrderDetailsDTO>();
            CreateMap<AddOrderDetailsDTO, OrderDetail>();
        }
        
    }
}