using DeliveryOrder.Core.Models;

namespace DeliveryOrder.Application.Services
{
    public interface IOrdersService
    {
        Task<Guid> CreateOrder(Order order);
        Task<Guid> DeleteOrder(Guid id);
        Task<List<Order>> GetAllOrders();
    }
}