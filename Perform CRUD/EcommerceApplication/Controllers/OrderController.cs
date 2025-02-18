using EcommerceApplication.IRepository;
using EcommerceApplication.Model.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace EcommerceApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrder _order;
        public OrderController(IOrder order)
        {
            _order = order;
        }
        [HttpGet("GetAllOrders")]
        public async Task<IActionResult> GetAllOrders()
        {
            var orders = await _order.GetAllOrders();
            if (orders.IsNullOrEmpty()) throw new FileNotFoundException("There is no order available");
            return Ok(orders);
        }
        [HttpGet("GetOrderById")]
        public async Task<IActionResult> GetOrderById(Guid id)
        {
            var order = await _order.GetOrderById(id);
            if (order == null) throw new FileNotFoundException($"No Order Found by id = {id}");
            return Ok(order);
        }
        [HttpPost("AddOrder")]
        public async Task<IActionResult> AddOrder(OrderAddDto orderDto)
        {
            var order = await _order.AddOrder(orderDto);
            if (order == null) throw new ApplicationException("Order details are invalid.");
            return Ok(order);
        }
        [HttpDelete("DeleteOrder")]
        public async Task<IActionResult> DeleteOrder(Guid id)
        {
            var order = await _order.DeleteOrder(id);
            if (order == null) throw new FileNotFoundException($"No Order Found by id = {id}");
            return Ok(order);
        }
        [HttpPut("UpdateOrder")]
        public async Task<IActionResult> UpdateOrder(OrderUpdateDto orderDto)
        {
            var order = await _order.UpdateOrder(orderDto);
            if (order == null) throw new ApplicationException("Order details are invalid.");
            return Ok(order);
        }
    }
}
