using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace DeliveryOrder.DataAccess
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<DeliveryOrderDbContext>
    {
        public DeliveryOrderDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DeliveryOrderDbContext>();
            optionsBuilder.UseNpgsql("User ID=postgres;Password=password;Host=localhost;Port=5432;Database=deliverydb;");

            return new DeliveryOrderDbContext(optionsBuilder.Options);
        }
    }
}
