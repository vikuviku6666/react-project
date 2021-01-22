

using react_project.DTO.Order;
using react_project.DTO.Product;

namespace react_project.DTO.OrderDetails
{
    public class OrderDetailsDTO
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int ProductId { get; set; }
        public int OrderId { get; set; }
       /*  public GetOrderDTO Order { get; set; }
        public GetProductDTO Product { get; set; } */


    }
}