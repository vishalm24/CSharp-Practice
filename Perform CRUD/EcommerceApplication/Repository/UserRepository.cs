using EcommerceApplication.Data;
using EcommerceApplication.IRepository;
using EcommerceApplication.Model;
using EcommerceApplication.Model.Dto;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace EcommerceApplication.Repository
{
    public class UserRepository : IUser
    {
        private readonly ApplicationDbContext _context;
        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<UserDto> AddUser(UserAddDto userDto)
        {
            var user = new User();
            user.FirstName = userDto.FirstName;
            user.LastName = userDto.LastName;
            user.PhoneNumber = userDto.PhoneNumber;
            user.Email = userDto.Email;
            user.IsActive = userDto.IsActive;
            _context.Users.Add(user);
            var userDetails = await showDetails(user);
            await _context.SaveChangesAsync();
            return userDetails;
        }

        public async Task<UserDto> DeleteUser(Guid id)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Id == id && u.IsActive);
            if (user == null) return null;
            user.IsActive = false;
            await _context.SaveChangesAsync();
            var userDetail = await showDetails(user);
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
            var userDetail = new UserDto();
            if (user != null)
            {
                userDetail.Id = user.Id;
                userDetail.FirstName = user.FirstName;
                userDetail.LastName = user.LastName;
                userDetail.PhoneNumber = user.PhoneNumber;
                userDetail.Email = user.Email;
                userDetail.Address = user.Address;
                return userDetail;
            }
            return null;
        }

        public async Task<IEnumerable<UserDto>> GetUsers()
        {
            var users = new List<UserDto>();
            foreach (var item in _context.Users.ToList().FindAll(u => u.IsActive == true))
            {
                var user = new UserDto
                {
                    Id = item.Id,
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                    PhoneNumber = item.PhoneNumber,
                    Email = item.Email,
                    Address = item.Address
                };
                users.Add(user);
            }
            return users;
        }

        public async Task<User> UpdateUser(UserUpdateDto userDto)
        {
            var userDetail = await _context.Users.FirstOrDefaultAsync(u => u.Id == userDto.Id);
            if(userDetail == null)
                return null;
            userDetail.Id = userDto.Id;
            userDetail.FirstName = userDto.FirstName;
            userDetail.LastName = userDto.LastName;
            userDetail.PhoneNumber = userDto.PhoneNumber;
            userDetail.Email = userDto.Email;
            userDetail.Address = userDto.Address;
            _context.Users.Update(userDetail);
            await _context.SaveChangesAsync();
            return userDetail;
        }

        public async Task<UserDto> showDetails(User user)
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
