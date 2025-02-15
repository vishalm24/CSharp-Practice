﻿using EcommerceApplication.Data;
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
        public async Task AddUser(UserAddDto user)
        {
            var newUser = new User
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                PhoneNumber = user.PhoneNumber,
                Email = user.Email,
                Address = user.Address,
                IsActive = user.IsActive
            };
            _context.Users.Add(newUser);
            await _context.SaveChangesAsync();
            return;
        }

        public async Task<bool> DeleteUser(Guid id)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Id == id && u.IsActive);
            if(user !=  null)
            {
                user.IsActive = false;
                _context.SaveChanges();
                return true;
            }
            return false;
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
            return userDetail;
        }
    }
}
