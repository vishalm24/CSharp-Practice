using EcommerceApplication.Data;
using EcommerceApplication.IRepository;
using EcommerceApplication.Model;
using EcommerceApplication.Model.Dto;
using EcommerceApplication.Pagination;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EcommerceApplication.Repository
{
    public class UserRepository : IUser
    {
        private readonly ApplicationDbContext _context;
        private object context;
        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<OrdersByUserIdDto>> OrdersPlacedByUser(Guid id)
        {
            var orders = await _context.Orders.Where(o => o.UserId == id && o.IsActive).ToListAsync();
            var orderDetails = new List<OrdersByUserIdDto>();
            foreach (var item in orders)
            {
                var order = new OrdersByUserIdDto
                {
                    orderId = item.Id,
                    productName = await _context.Products.Where(p => p.Id == item.ProductId).Select(p => p.Name).FirstOrDefaultAsync(),
                    price = item.Price,
                    categoryName = await _context.Categories.Where(c => c.Id == _context.Products.First(p => p.Id == item.ProductId).Id).Select(c => c.Name).FirstOrDefaultAsync()
                };
                orderDetails.Add(order);
            }
            return orderDetails;
        }
        public async Task<UserDto> AddUser(UserAddDto userDto)
        {
            var user = new User();
            if (user == null) return null;
            user.FirstName = userDto.FirstName;
            user.LastName = userDto.LastName;
            user.PhoneNumber = userDto.PhoneNumber;
            user.Email = userDto.Email;
            user.Address = userDto.Address;
            user.IsActive = userDto.IsActive;
            _context.Users.Add(user);
            var userDetails = showDetails(user);
            await _context.SaveChangesAsync();
            return userDetails;
        }

        public async Task<UserDto> DeleteUser(Guid id)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Id == id && u.IsActive);
            if (user == null) return null;
            user.IsActive = false;
            await _context.SaveChangesAsync();
            var userDetail = showDetails(user);
            await DeleteOrders(id);
            await _context.SaveChangesAsync();
            return userDetail;
        }
        public async Task DeleteOrders(Guid userId)
        {
            var orders =  _context.Orders.ToList().FindAll(o => o.UserId == userId);
            foreach (var item in orders)
            {
                var order = await _context.Orders.FirstOrDefaultAsync(o => o.Id == item.Id);
                order.IsActive = false;
                _context.Orders.Update(order);
            }
        }

        public async Task<UserDto> GetUserById(Guid id)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Id == id && u.IsActive);
            if (user == null) return null;
            var userDetail = showDetails(user);
            return userDetail;
        }

        public async Task<IEnumerable<UserDto>> GetUsers()
        {
            var users = new List<UserDto>();
            foreach (var item in _context.Users.ToList().FindAll(u => u.IsActive == true))
            {
                var user = showDetails(item);
                users.Add(user);
            }
            return users;
        }

        public async Task<UserDto> UpdateUser(UserUpdateDto userDto)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Id == userDto.Id);
            if(user == null) return null;
            user.Id = userDto.Id;
            user.FirstName = userDto.FirstName;
            user.LastName = userDto.LastName;
            user.PhoneNumber = userDto.PhoneNumber;
            user.Email = userDto.Email;
            user.Address = userDto.Address;
            _context.Users.Update(user);
            await _context.SaveChangesAsync();
            var userDetail = showDetails(user);
            return userDetail;
        }

        public async Task<PagedResponseOffset> GetUsersByPage(int page)
        {
            int TotalRecords = _context.Users.Where(u => u.IsActive).Count();
            int pageSize = 5;
            int skipUsers = (page - 1) * pageSize;
            ////By Raw SQL
            var users = await _context.Users.FromSqlRaw<User>("spGetCustomerByPage {0}, {1}", skipUsers, pageSize).ToListAsync();
            ////By LINQ
            //var users = await _context.Users.Where(u => u.IsActive).OrderBy(u => u.FirstName).Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();
            var userDetails = new List<UserDto>();
            foreach (var item in users)
            {
                var user = showDetails(item);
                userDetails.Add(user);
            }
            var pagedResonseOffset = getUserWithPage(userDetails, pageSize, page, TotalRecords);
            return pagedResonseOffset;
        }

        public PagedResponseOffset getUserWithPage(List<UserDto> userDetails, int pageSize, int page, int TotalRecords)
        {
            return new PagedResponseOffset(userDetails, pageSize, page, TotalRecords);
        }

        public UserDto showDetails(User user)
        {
            var userDetail = new UserDto();
            userDetail.Id = user.Id;
            userDetail.FirstName = user.FirstName;
            userDetail.LastName = user.LastName;
            userDetail.PhoneNumber = user.PhoneNumber;
            userDetail.Email = user.Email;
            userDetail.Address = user.Address;
            return userDetail;
        }
    }
}
