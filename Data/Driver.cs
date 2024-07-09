using System.ComponentModel.DataAnnotations;

namespace StoreApp.Data
{
    public class Driver
    {
        [Key]
        public int DriverId { get; set; }
        public string? DriverName { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
    }
}
