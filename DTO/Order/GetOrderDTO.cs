using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using react_project.DTO.OrderDetails;


namespace react_project.DTO.Order
{
    public class GetOrderDTO
    {
        public int Id { get; set; }

        public DateTime Created { get; set; }

        public string CreatedBy { get; set; }

        public string PaymentMethod { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal TotalPrice { get; set; }
        public ICollection<OrderDetailsDTO> OrderDetails { get; set; }
    }
}