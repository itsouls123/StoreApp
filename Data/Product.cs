namespace StoreApp.Data
{
    public class Product
    {
        public long ProductId { get; set; }
        public string? Name { get; set; }
        public string? Category { get; set; }
        public int MinQtyLimit { get; set; }
        public long TotalQty { get; set; }
    }
}
