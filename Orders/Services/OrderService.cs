using System;
using System.Collections.Generic;
using System.Text;
using Orders.Models;
using System.Linq;
using System.Threading.Tasks;

namespace Orders.Services
{
    public class OrderService : IOrderService
    {
        private IList<Order> orders;
        public OrderService()
        {
            orders = new List<Order> {
                new Order("1000", "250 Conference brochures", DateTime.Now, 1, "d52b8156-b996-42fd-bdda-2f2405af9be8"),
                new Order("2000", "250 T-Shirts", DateTime.Now, 2, "a0a7c4f3-7801-4cb0-82dc-9d63463d02ad"),
                new Order("3000", "500 Stickers", DateTime.Now, 3, "b827e08a-dff8-4bd2-a89f-7610f2b6552d"),
                new Order("4000", "10 Posters", DateTime.Now, 4, "1d26ac55-7047-4aee-87d1-e5169ed436c6")
            };

        }
        public Task<Order> GetOrderByIdAsync(string id)
        {
            return Task.FromResult(orders.Single(o => o.Id == id));
        }

        public Task<IEnumerable<Order>> GetOrdersAsync()
        {
            return Task.FromResult(orders.AsEnumerable());
        }
    }
    public interface IOrderService
    {
        Task<Order> GetOrderByIdAsync(string id);
        Task<IEnumerable<Order>> GetOrdersAsync();
    }
}
