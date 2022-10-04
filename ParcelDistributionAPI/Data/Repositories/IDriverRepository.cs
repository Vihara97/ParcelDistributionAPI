using ParcelDistributionAPI.Data.Models;
using System.Collections.Generic;

namespace ParcelDistributionAPI.Data.Repositories
{
    public interface IDriverRepository
    {
        List<Driver> GetAllDrivers();
    }
}
