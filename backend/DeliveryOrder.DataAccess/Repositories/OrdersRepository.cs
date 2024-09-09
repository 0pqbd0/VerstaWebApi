using DeliveryOrder.Core.Models;
using DeliveryOrder.DataAccess.Entyties;
using Microsoft.EntityFrameworkCore;

namespace DeliveryOrder.DataAccess.Repositories
{
    public class OrdersRepository : IOrdersRepository
    {
        private readonly DeliveryOrderDbContext _context;
        public OrdersRepository(DeliveryOrderDbContext context)
        {
            _context = context;
        }

        public async Task<List<Order>> Get()
        {
            var orderEntities = await _context.Orders
                .AsNoTracking()
                .ToListAsync();

            var orders = orderEntities
                .Select(b => Order.Create(b.Id, b.SenderCity, b.SenderAddress, b.RecipientCity,
                b.RecipientAddress, b.Weight, b.PickUpDate))
                .ToList();

            return orders;
        }

        public async Task<Guid> Create(Order order)
        {
            var orderEntity = new OrderEntity
            {
                Id = order.Id,
                SenderCity = order.SenderCity,
                SenderAddress = order.SenderAddress,
                RecipientCity = order.RecipientCity,
                RecipientAddress = order.RecipientAddress,
                Weight = order.Weight,
                PickUpDate = order.PickUpDate.ToUniversalTime(),
            };

            await _context.Orders.AddAsync(orderEntity);
            await _context.SaveChangesAsync();

            return orderEntity.Id;

        }

        public async Task<Guid> Delete(Guid id)
        {
            await _context.Orders
                .Where(b => b.Id == id)
                .ExecuteDeleteAsync();

            return id;
        }
    }
}
