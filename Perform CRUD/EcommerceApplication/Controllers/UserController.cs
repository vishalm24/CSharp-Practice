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
            if(users == null)
            {
                return NotFound("There are no users available");
            }
            return Ok(users);
        }
        [HttpGet("GetUserById")]
        public async Task<IActionResult> GetUserById(Guid id)
        {
            var user = _user.GetUserById(id);
            if(user == null)
            {
                return NotFound("User not found");
            }
            return Ok(user);
        }
        [HttpPost("AddUser")]
        public async Task<IActionResult> AddUser(UserDto dto)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest("Invalid Data");
            }
            var user = new UserAddDto
            {
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                PhoneNumber = dto.PhoneNumber,
                Email = dto.Email,
                Address = dto.Address
            };
            await _user.AddUser(user);
            return Ok();
        }
        [HttpDelete("DeleteUser")]
        public async Task<IActionResult> DeleteUser(Guid id)
        {
            var result = await _user.DeleteUser(id);
            if (result)
            {
                return Ok();
            }
            return NotFound();
        }
    }
}
