using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParcelDistributionAPI.Data.Models
{
    public class Booking
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BookingId { get; set; }

        public int CustomerId { get; set; }

        public int DriverId { get; set; }

        public string FromAddress { get; set; }

        public string ToAddress { get; set; }

        public int TypeOfGoods { get; set; }

        public DateTime DateTime { get; set; }

        public decimal Weight { get; set; }

        public int PricingMechanism { get; set; }

        public int Status { get; set; }

    }
}
