using EcommerceApplication.IRepository;
using EcommerceApplication.Model;
using EcommerceApplication.Model.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using Microsoft.IdentityModel.Tokens;
using IUser = EcommerceApplication.IRepository.IUser;

namespace EcommerceApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUser _user;
        public UserController(IUser user)
        {
            _user = user;
        }
        [HttpGet("GetUsers")]
        public async Task<IActionResult> GetUsers()
        {
            var users = await _user.GetUsers();
            if(users.IsNullOrEmpty()) throw new FileNotFoundException("There is no user available.");
            return Ok(users);
        }
        [HttpGet("GetUserById")]
        public async Task<IActionResult> GetUserById(Guid id)
        {
            var user = await _user.GetUserById(id);
            if (user == null) throw new FileNotFoundException($"No User Found by id = {id}");
            return Ok(user);
        }
        [HttpPost("AddUser")]
        public async Task<IActionResult> AddUser(UserAddDto userDto)
        {
            if (!ModelState.IsValid) throw new ApplicationException("User details are invalid.");
            var user = await _user.AddUser(userDto);
            if (user == null) throw new ApplicationException("User details are invalid.");
            return Ok(user);
        }
        [HttpDelete("DeleteUser")]
        public async Task<IActionResult> DeleteUser(Guid id)
        {
            var user = await _user.DeleteUser(id);
            if (user == null) throw new FileNotFoundException($"No User Found by id = {id}");
            return Ok(user);
        }
        [HttpPut("UpdateUser")]
        public async Task<IActionResult> UpdateUser(UserUpdateDto userDto)
        {
            if (!ModelState.IsValid) throw new ApplicationException("User details are invalid.");
            var user = await _user.UpdateUser(userDto);
            if (user == null) throw new FileNotFoundException($"No User Found by id = {userDto.Id}");
            return Ok(user);
        }
        [HttpGet("OrdersPlacedByUser")]
        public async Task<IActionResult> OrdersPlacedByUser(Guid id)
        {
            var user = await _user.OrdersPlacedByUser(id);
            if (user.IsNullOrEmpty()) throw new FileNotFoundException($"No Order is placed by User {id}");
            return Ok(user);
        }
        [HttpGet("GetUsersByPage")]
        public async Task<IActionResult> GetUsersByPage(int page)
        {
            var users = await _user.GetUsersByPage(page);
            if(users.IsNullOrEmpty()) throw new FileNotFoundException($"There are no products on page number {page}");
            return Ok(users);
        }
    }
}
