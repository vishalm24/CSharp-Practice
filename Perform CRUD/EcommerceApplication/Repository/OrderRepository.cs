using EcommerceApplication.Data;
using EcommerceApplication.IRepository;
using EcommerceApplication.Model;
using EcommerceApplication.Model.Dto;
using Microsoft.EntityFrameworkCore;

namespace EcommerceApplication.Repository
{
    public class OrderRepository: IOrder
    {
        private readonly ApplicationDbContext _context;
        public OrderRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<OrderDto> AddOrder(OrderAddDto orderDto)
        {
            var product = await _context.Products.FirstOrDefaultAsync(p => p.Id == orderDto.ProductId && p.IsActive);
            var customer = await _context.Users.FirstOrDefaultAsync(u => u.Id == orderDto.UserId && u.IsActive);
            if(product == null || customer == null) return null;
            var orderDetails = new Order
            {
                UserId = orderDto.UserId,
                ProductId = orderDto.ProductId,
                Price = product.Price,
                IsActive = orderDto.IsActive
            };
            _context.Orders.Add(orderDetails);
            await _context.SaveChangesAsync();
            var orderDtoDetail = await showDetails(orderDetails);
            return orderDtoDetail;
        }

        public async Task<OrderDto> DeleteOrder(Guid id)
        {
            var order = await _context.Orders.FirstOrDefaultAsync(o => o.Id == id && o.IsActive);
            if(order == null) return null;
            order.IsActive = false;
            _context.Orders.Update(order);
            await _context.SaveChangesAsync();
            var orderDetails = await showDetails(order);
            return orderDetails;
        }

        public async Task<IEnumerable<OrderDto>> GetAllOrders()
        {
            var orders = await _context.Orders
                            .Where(o => o.IsActive)
                            .Include(u => u.User)
                            .Include(p => p.Product)
                            .Select(o => new OrderDto
                            {
                                Id = o.Id,
                                UserFirstName = o.User.FirstName,
                                UserLastName = o.User.LastName,
                                ProductName = o.Product.Name,
                                Price = o.Product.Price
                            }).ToListAsync();
            if(orders == null) return null;
            return orders;
        }

        public async Task<OrderDto> GetOrderById(Guid id)
        {
            var order = await _context.Orders.FirstOrDefaultAsync(o => o.Id == id && o.IsActive);
            if(order == null) return null;
            var orderDetails = await showDetails(order);
            return orderDetails;
        }

        public async Task<OrderDto> UpdateOrder(OrderUpdateDto orderDto)
        {
            var order = await _context.Orders.FirstOrDefaultAsync(o => o.Id == orderDto.Id && o.IsActive);
            var product = await _context.Products.FirstOrDefaultAsync(p => p.Id == orderDto.ProductId && p.IsActive);
            var customer = await _context.Users.FirstOrDefaultAsync(u => u.Id == orderDto.UserId && u.IsActive);
            if(order == null || product == null || customer == null) return null;
            order.UserId = orderDto.UserId;
            order.ProductId = orderDto.ProductId;
            order.Price = orderDto.Price;
            order.IsActive = orderDto.IsActive;
            _context.Orders.Update(order);
            await _context.SaveChangesAsync();
            var orderDetails = await showDetails(order);
            return orderDetails;
        }
        public async Task<OrderDto> showDetails(Order order)
        {
            var orderDto = new OrderDto
            {
                Id = order.Id,
                UserFirstName = order.User.FirstName,
                UserLastName = order.User.LastName,
                ProductName = order.Product.Name,
                Price = order.Product.Price
            };
            return orderDto;
        }
        public async Task<IEnumerable<OrderDto>> GetOrdersByPage(int page)
        {
            int pageSize = 5;
            var orders = await _context.Orders
                            .Where(o => o.IsActive)
                            .OrderBy(o => o.Id)
                            .Skip((page-1)*pageSize)
                            .Take(pageSize)
                            .Include(u => u.User)
                            .Include(p => p.Product)
                            .Select(o => new OrderDto
                            {
                                Id = o.Id,
                                UserFirstName = o.User.FirstName,
                                UserLastName = o.User.LastName,
                                ProductName = o.Product.Name,
                                Price = o.Product.Price
                            }).ToListAsync();
            if (orders == null) return null;
            return orders;
        }
    }
}
