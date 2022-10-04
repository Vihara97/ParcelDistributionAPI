using Microsoft.AspNetCore.Mvc;
using ParcelDistributionAPI.Data.Models;
using ParcelDistributionAPI.Data.Repositories;
using System.Collections.Generic;

namespace ParcelDistributionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerController(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        [HttpGet]
        [Route("GetAllCustomers")]
        public IEnumerable<Customer> GetAllCustomers()
        {
            return _customerRepository.GetAllCustomers();
        }

        [HttpPost]
        [Route("AddCustomer")]
        public bool AddCustomer(Customer customer)
        {
            return _customerRepository.AddCustomer(customer);
        }

        [HttpPut]
        [Route("EditCustomer")]
        public bool EditCustomer(Customer customer)
        {
            return _customerRepository.EditCustomer(customer);
        }

        [HttpGet]
        [Route("GetCustomerById")]
        public Customer GetCustomerById(int id)
        {
            return _customerRepository.GetCustomerById(id);
        }

        [HttpDelete]
        [Route("DeleteCustomerById")]
        public bool DeleteCustomerById(int id)
        {
            return _customerRepository.DeleteCustomerById(id);
        }
    }
}
