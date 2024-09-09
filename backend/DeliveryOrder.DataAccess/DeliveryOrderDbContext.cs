using DeliveryOrder.DataAccess.Entyties;
using Microsoft.EntityFrameworkCore;

namespace DeliveryOrder.DataAccess
{
    public class DeliveryOrderDbContext : DbContext
    {
         public DeliveryOrderDbContext(DbContextOptions<DeliveryOrderDbContext> options)
            : base(options) 
        {
            
        }

        public DbSet<OrderEntity> Orders { get; set; }
    }
}
