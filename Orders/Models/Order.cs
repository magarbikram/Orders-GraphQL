using System;
using System.Collections.Generic;
using System.Text;

namespace Orders.Models
{
    public class Order
    {
        public Order(string name, string description, DateTime created, int customerId, string id)
        {
            Name = name;
            Description = description;
            Created = created;
            CustomerId = customerId;
            Id = id;
            Status = OrderStatus.Created;
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; private set; }
        public int CustomerId { get; set; }
        public string Id { get; private set; }

        public OrderStatus Status { get; set; }
    }

    public enum OrderStatus
    {
        Created = 2,
        Processing = 4,
        Completed = 8,
        Canceled = 16
    }
}
