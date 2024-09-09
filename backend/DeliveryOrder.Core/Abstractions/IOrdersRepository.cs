using DeliveryOrder.Core.Models;

namespace DeliveryOrder.DataAccess.Repositories
{
    public interface IOrdersRepository
    {
        Task<Guid> Create(Order order);
        Task<Guid> Delete(Guid id);
        Task<List<Order>> Get();
    }
}