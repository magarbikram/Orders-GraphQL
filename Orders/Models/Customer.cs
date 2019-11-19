using System;
using System.Collections.Generic;
using System.Text;

namespace Orders.Models
{
    public class Customer
    {
        public Customer(int id, string name)
        {
            Id = id;
            Name = name;
            ShippingAddress = "4562 E Bell Rd, Phoenix AZ 85032";
            BillingAddress = "4562 E Bell Rd, Phoenix AZ 85032";
        }

        public int Id { get; private set; }
        public string Name { get; set; }
        public string ShippingAddress { get; set; }
        public string BillingAddress { get; set; }
    }
}
