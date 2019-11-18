using Orders.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders.Services
{
    public class CustomerService : ICustomerService
    {
        private IList<Customer> customers;
        public CustomerService()
        {
            customers = new List<Customer>() {
                new Customer(1, "KinetEco"),
                new Customer(2, "Pixelford Photography"),
                new Customer(3, "Topsy Turvy"),
                new Customer(4, "Leaf & Mortar")
            };
        }
        public Customer GetCustomerById(int id)
        {
            return GetCustomerByIdAsync(id).Result;
        }

        public Task<Customer> GetCustomerByIdAsync(int id)
        {
            return Task.FromResult(customers.Single(c => c.Id == id));
        }

        public Task<IEnumerable<Customer>> GetCustomersAsync()
        {
            return Task.FromResult(customers.AsEnumerable());
        }
    }
    public interface ICustomerService {
        Customer GetCustomerById(int id);
        Task<Customer> GetCustomerByIdAsync(int id);
        Task<IEnumerable<Customer>> GetCustomersAsync();
    }
}
