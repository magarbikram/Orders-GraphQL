using System;
using System.Collections.Generic;
using System.Text;
using GraphQL.Types;
using System.Linq;
using Orders.Services;

namespace Orders.Schema
{
    public class OrdersQuery: ObjectGraphType<object>
    {
        public OrdersQuery(IOrderService orderService)
        {
            Name = "Query";
            Field<ListGraphType<OrderType>>(
                "orders",
                resolve: context => orderService.GetOrdersAsync()
            );
        }
    }
}
