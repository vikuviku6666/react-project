using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace react_project.Models
{
    public class Order
    {
        public int Id { get; set; }

        public DateTime Created { get; set; }

        public string CreatedBy { get; set; }

        public string PaymentMethod { get; set; }
        
        [Column(TypeName = "decimal(18, 2)")]
        public decimal TotalPrice { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}