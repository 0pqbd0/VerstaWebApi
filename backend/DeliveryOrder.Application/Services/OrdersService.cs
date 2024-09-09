using DeliveryOrder.Core.Models;
using DeliveryOrder.DataAccess.Repositories;

namespace DeliveryOrder.Application.Services
{
    public class OrdersService : IOrdersService
    {
        private readonly IOrdersRepository _ordersRepository;
        public OrdersService(IOrdersRepository ordersRepository)
        {
            _ordersRepository = ordersRepository;
        }

        public async Task<List<Order>> GetAllOrders()
        {
            return await _ordersRepository.Get();
        }

        public async Task<Guid> CreateOrder(Order order)
        {
            return await _ordersRepository.Create(order);
        }

        public async Task<Guid> DeleteOrder(Guid id)
        {
            return await _ordersRepository.Delete(id);
        }
    }
}
