using Microsoft.EntityFrameworkCore;
using Practicing_JWT.Data;
using Practicing_JWT.IRepository;
using Practicing_JWT.Model;

namespace Practicing_JWT.Repository
{
    public class OrderRepository: IOrderRepo
    {
        private readonly ApplicationDbContext _context;
        public OrderRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Order> AddOrder(OrderDto orderDto)
        {
            var order = new Order
            {
                UserId = orderDto.UserId,
                ProductName = orderDto.ProductName
            };
            var orderDetails = _context.Order.Add(order).Entity;
            await _context.SaveChangesAsync();
            return orderDetails;
        }
    }
}
