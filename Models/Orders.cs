using System;

namespace react_project.Models
{
    public class Orders
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public string PaymentMethod { get; set; }
        public float Total { get; set; }
    }
}