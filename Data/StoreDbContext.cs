using Microsoft.EntityFrameworkCore;

namespace StoreApp.Data
{
    public class StoreDbContext : DbContext
    {
        public StoreDbContext(DbContextOptions<StoreDbContext> options) 
            : base(options) 
        { 
        
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("store");
        }
    }

    //below code is used in case of multi dbcontext or db
    //public class OrderDbContext : DbContext
    //{
    //    public DbSet<Order> Orders { get; set; }

    //    public DbSet<LineItem> LineItems { get; set; }

    //    protected override void OnModelCreating(ModelBuilder modelBuilder)
    //    {
    //        modelBuilder.HasDefaultSchema("order");
    //    }
    //}
}
