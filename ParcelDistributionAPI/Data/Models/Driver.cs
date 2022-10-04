using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParcelDistributionAPI.Data.Models
{
    public class Driver
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DriverId { get; set; }

        public string DriverFirstName { get; set; }

        public string DriverLastName { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public int Status { get; set; }
    }
}
