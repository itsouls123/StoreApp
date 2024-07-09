using System.ComponentModel.DataAnnotations;

namespace StoreApp.Data
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        public string? Name { get; set; }
        public string? FName { get; set; }
        public int Age { get; set; }
    }
}
