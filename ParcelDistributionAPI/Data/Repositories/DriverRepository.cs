using ParcelDistributionAPI.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParcelDistributionAPI.Data.Repositories
{
    public class DriverRepository : IDriverRepository
    {
        private readonly DataContext _dataContext;

        public DriverRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public List<Driver> GetAllDrivers()
        {
            try
            {
                if (_dataContext != null)
                {
                    return _dataContext.Drivers.ToList();
                }

                return null;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
