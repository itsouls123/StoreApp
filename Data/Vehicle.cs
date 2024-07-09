using System.ComponentModel.DataAnnotations;

namespace StoreApp.Data
{
    public class Vehicle
    {
        [Key]
        public int VehicleId { get; set; }
        public string? VehicleNumber { get; set; }
        public string? Type { get; set; }
        [MaxLength(5)]
        public int Capacity { get; set; }
    }
}
