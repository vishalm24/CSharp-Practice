using EcommerceApplication.Model.Dto;

namespace EcommerceApplication.IRepository
{
    public interface IOrder
    {
        public Task<IEnumerable<OrderDto>> GetAllOrders();
        public Task<OrderDto> GetOrderById(Guid id);
        public Task<OrderDto> AddOrder(OrderAddDto order);
        public Task<OrderDto> UpdateOrder(OrderUpdateDto order);
        public Task<OrderDto> DeleteOrder(Guid id);
    }
}
