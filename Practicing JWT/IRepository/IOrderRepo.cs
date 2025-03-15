using Practicing_JWT.Model;

namespace Practicing_JWT.IRepository
{
    public interface IOrderRepo
    {
        public Task<Order> AddOrder(OrderDto orderDto);
    }
}
