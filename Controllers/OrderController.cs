using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using react_project.Contexts;
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
            return Ok(await _context.Orders.Include(b => b.OrderDetails).ToListAsync());
        }

/* 
        [HttpDelete]
        [Route("{id}")]

        public async Task<ActionResult> DeleteOrder(int id)
        {
            Product found = await _context.Orders.First(c => c.Id == id);
            _context.Orders.Remove(found);

            if (found == null)
            {
                return NotFound();
            }
            return Ok(found);
        } */

        [HttpPost]
        public async Task<ActionResult> CreateOrder(Order newOrder)
        {
            _context.Orders.Add(newOrder);
            await _context.SaveChangesAsync();

            return CreatedAtAction("CreateOrder", newOrder);

        }
    }
}