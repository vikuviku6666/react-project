using System.Collections.Generic;
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
    public class ProductController : ControllerBase
    {
        private readonly ProductContext _context;
        private readonly IMapper _mapper;

        public ProductController(ProductContext context, IMapper mapper)
        {
            _mapper = mapper;
            
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult> GetProducts()
        {
            return Ok(await _context.Products.ToListAsync());
        }

        [HttpGet]
        [Route("{id}")]

        public async Task<ActionResult> GetById(int id)
        {
            Product found = await _context.Products.FindAsync(id);

            if (found == null)
            {
                return NotFound();
            }
            return Ok(found);
        }

        [HttpPost]
        public async Task<ActionResult> CreateProduct(Product newProduct)
        {
            _context.Products.Add(newProduct);
            await _context.SaveChangesAsync();

            return CreatedAtAction("CreateProduct", newProduct);

        }
    }
}