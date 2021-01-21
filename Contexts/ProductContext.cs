using Microsoft.EntityFrameworkCore;
using react_project.Models;

namespace react_project.Contexts
{
    public class ProductContext : DbContext
    {
         public ProductContext(DbContextOptions<ProductContext> options) : base(options) { } 

        protected override void OnConfiguring(DbContextOptionsBuilder options)
         => options.UseSqlite("Data Source = DB/Product.db");

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

    }

}