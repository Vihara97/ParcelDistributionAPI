using ParcelDistributionAPI.Data.Models;
using System.Collections.Generic;

namespace ParcelDistributionAPI.Data.Repositories
{
    public interface IBookingRepository
    {
        bool AddBooking(Booking booking);

        List<Booking> GetAllBookings();
    }
}
