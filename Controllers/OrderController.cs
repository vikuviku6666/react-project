using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using react_project.Contexts;
using react_project.DTO.Order;
using react_project.Models;

namespace react_project.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly ProductContext _context;
        private readonly IMapper _mapper;

        public OrderController(ProductContext context, IMapper mapper)
        {
            _mapper = mapper;

            _context = context;
        }


        [HttpGet]
        public async Task<ActionResult> GetOrders()
        {
            List<Order> orders = await _context.Orders.Include(b => b.OrderDetails).ToListAsync();

            List<GetOrderDTO> orderDTOs = _mapper.Map<List<GetOrderDTO>>(orders);

            return Ok(orderDTOs);
        }


        [HttpPost]
        public async Task<ActionResult> CreateOrder(AddOrderDTO newAddOrderDTO)
        {
            Order newOrder = _mapper.Map<Order>(newAddOrderDTO);

            _context.Orders.Add(newOrder);
            
            await _context.SaveChangesAsync();

            return CreatedAtAction("CreateOrder", newOrder);

        }
    }
}