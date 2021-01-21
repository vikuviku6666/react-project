using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using react_project.Models;
using react_project.DTO.OrderDetails;
namespace react_project.DTO.Order
{
    public class AddOrderDTO
    {
        public int Id { get; set; }

        public DateTime Created { get; set; }

        public string CreatedBy { get; set; }

        public string PaymentMethod { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal TotalPrice { get; set; }
        public ICollection<OrderDetailDTO> OrderDetails { get; set; }
    }
}