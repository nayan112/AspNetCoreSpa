using System.Collections.Generic;
using MyCommunity.Core.Entities;

namespace MyCommunity.Infrastructure
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        IEnumerable<Customer> GetTopActiveCustomers(int count);
        IEnumerable<Customer> GetAllCustomersData();
    }
}
