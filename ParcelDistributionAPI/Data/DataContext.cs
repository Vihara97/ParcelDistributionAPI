using Microsoft.EntityFrameworkCore;
using ParcelDistributionAPI.Data.Models;

namespace ParcelDistributionAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Driver> Drivers { get; set; }

        public DbSet<Booking> Bookings { get; set; }
    }
}
