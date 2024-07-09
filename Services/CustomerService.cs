using Microsoft.EntityFrameworkCore;
using StoreApp.Data;

namespace StoreApp.Services
{
    public class CustomerService
    {
        private IDbContextFactory<StoreDbContext> _dbContextFactory;
        public CustomerService(IDbContextFactory<StoreDbContext> dbContextFactory) 
        { 
        _dbContextFactory = dbContextFactory;
        }
        public void AddCustomer(Customer customer)
        {
            using(var context = _dbContextFactory.CreateDbContext())
            { 
            context.Customers.Add(customer);
                context.SaveChanges();
            }
        }

    }
}
