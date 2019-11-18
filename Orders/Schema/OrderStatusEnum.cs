using System;
using System.Collections.Generic;
using System.Text;
using GraphQL.Types;
using Orders.Models;

namespace Orders.Schema
{
    public class OrderStatusEnum:EnumerationGraphType<OrderStatus>
    {
    }
}
