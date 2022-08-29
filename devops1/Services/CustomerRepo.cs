using devops1.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace devops1.Services
{
    public class CustomerRepo : IRepo<int, Customer>
    {
        static List<Customer> _customer = new List<Customer>()
        {
            new Customer(){ Id = 1, Name = "Aritra", Age = 21 }
        };
        public async Task<Customer> Add(Customer item)
        {
            _customer.Add(item);
            return item;
        }
        public async Task<Customer> GetAll(Customer item)
        {
            return _customers;
        }
    }
}
