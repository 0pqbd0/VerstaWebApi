using DeliveryOrder.Application.Services;
using DeliveryOrder.Core.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using VerstaWeb.Contracts;

namespace VerstaWeb.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrdersController : ControllerBase
    {
        private readonly IOrdersService _ordersService;
        public OrdersController(IOrdersService ordersService)
        {
            _ordersService = ordersService;
        }

        [HttpGet]
        public async Task<ActionResult<List<OrderResponse>>> GetOrder()
        {
            var orders = await _ordersService.GetAllOrders();

            var response = orders.Select(b => new OrderResponse(b.Id, b.SenderCity, b.SenderAddress,
                b.RecipientCity, b.RecipientAddress, b.Weight, b.PickUpDate)).ToList();

            return Ok(response);
        }

        [HttpPost]
        public async Task<ActionResult<Guid>> CreateOrder([FromBody] OrderRequest request)
        {
            var order = Order.Create(
                Guid.NewGuid(),
                request.SenderCity,
                request.SenderAddress,
                request.RecipientCity,
                request.RecipientAddress,
                request.Weight,
                request.PickUpDate
                );

            var orderId = await _ordersService.CreateOrder(order);
            return Ok(orderId);
        }

        [HttpDelete("{id:guid}")]
        public async Task<ActionResult<Guid>> DeleteOrder(Guid id)
        {
            return await _ordersService.DeleteOrder(id);
        }
    }
}
