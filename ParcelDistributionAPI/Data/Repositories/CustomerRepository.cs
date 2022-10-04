using ParcelDistributionAPI.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ParcelDistributionAPI.Data.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly DataContext _dataContext;

        public CustomerRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public bool AddCustomer(Customer customer)
        {
            try
            {
                if (_dataContext != null)
                {
                    _dataContext.Customers.Add(customer);
                    return _dataContext.SaveChanges() > 0;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool DeleteCustomerById(int id)
        {
            try
            {
                if (_dataContext != null)
                {
                    var deleteCustomer = _dataContext.Customers.FirstOrDefault(x => x.CustomerId.Equals(id));
                    _dataContext.Customers.Remove(deleteCustomer);
                    return _dataContext.SaveChanges() > 0;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool EditCustomer(Customer customer)
        {
            try
            {
                if (_dataContext != null)
                {
                    var editCustomer = _dataContext.Customers.FirstOrDefault(x => x.CustomerId.Equals(customer.CustomerId));
                    if (editCustomer != null)
                    {
                        editCustomer.CustomerFirstName = customer.CustomerFirstName;
                        editCustomer.CustomerLastName = customer.CustomerLastName;
                        editCustomer.UserName = customer.UserName;
                        editCustomer.Password = customer.Password;
                    }

                    _dataContext.Update(editCustomer);
                    return _dataContext.SaveChanges() > 0;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<Customer> GetAllCustomers()
        {
            try
            {
                if (_dataContext != null)
                {
                    return _dataContext.Customers.ToList();
                }

                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Customer GetCustomerById(int id)
        {
            try
            {
                if (_dataContext != null)
                {
                    return _dataContext.Customers.FirstOrDefault(x => x.CustomerId.Equals(id));
                }

                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
