using AutoMapper;
using react_project.Dtos.Product;
using react_project.Models;

namespace react_project
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<Product, GetProductDto>();
            CreateMap<GetProductDto, Product>();
        }
        
    }
}