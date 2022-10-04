using ParcelDistributionAPI.Data.Models;
using System.Collections.Generic;

namespace ParcelDistributionAPI.Data.Repositories
{
    public interface ICustomerRepository
    {
        bool AddCustomer(Customer customer);

        List<Customer> GetAllCustomers();

        Customer GetCustomerById(int id);

        bool EditCustomer(Customer customer);

        bool DeleteCustomerById(int id);
    }
}
