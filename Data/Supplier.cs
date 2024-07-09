using System.ComponentModel.DataAnnotations;

namespace StoreApp.Data
{
    public class Supplier
    {
        [Key]
        public int SuppId { get; set; }
        public string? SuppCode { get; set; }
        public string? Name { get; set; }
        public string? RegNo { get; set; }
        public string? Address { get; set; }
        [MaxLength(11)]
        public int ContactNo { get; set; }
        public double CreditLimit { get; set; }
        public double Balance { get; set; }
        public DateTime PaymentDueNext { get; set; }
        public int PaymentSchedule { get; set; }
        public string? VatRegNo { get; set; }
        public string? BankName { get; set; }
        [MaxLength(8)]
        public int BankAccountNumber { get; set; }
        [MaxLength(6)]
        public int SortCode { get; set; }
    }
}
