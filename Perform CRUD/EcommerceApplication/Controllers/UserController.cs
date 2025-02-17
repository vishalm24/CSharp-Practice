using EcommerceApplication.IRepository;
using EcommerceApplication.Model;
using EcommerceApplication.Model.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
            var users = _user.GetUsers();
            if(users == null) throw new FileNotFoundException("There is no user available.");
            return Ok(users);
        }
        [HttpGet("GetUserById")]
        public async Task<IActionResult> GetUserById(Guid id)
        {
            var user = _user.GetUserById(id);
            if (user == null) throw new FileNotFoundException($"No User Found by id = {id}");
            return Ok(user);
        }
        [HttpPost("AddUser")]
        public async Task<IActionResult> AddUser(UserAddDto userDto)
        {
            if (!ModelState.IsValid) throw new ApplicationException("User details are invalid.");
            var userDetails = await _user.AddUser(userDto);
            if (userDetails == null) throw new ApplicationException("User details are invalid.");
            return Ok();
        }
        [HttpDelete("DeleteUser")]
        public async Task<IActionResult> DeleteUser(Guid id)
        {
            var user = await _user.DeleteUser(id);
            if (user == null) throw new FileNotFoundException($"No User Found by id = {id}");
            return user;
        }
        [HttpPut("UpdateUser")]
        public async Task<IActionResult> UpdateUser(UserDto dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid Data");
            }
            var user = new UserUpdateDto
            {
                Id = dto.Id,
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                PhoneNumber = dto.PhoneNumber,
                Email = dto.Email,
                Address = dto.Address
            };
            var userDetail = _user.UpdateUser(user);
            if (userDetail == null)
            {
                return NotFound("User not found");
            }
            return Ok();
        }
    }
}
