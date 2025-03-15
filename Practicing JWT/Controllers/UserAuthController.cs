using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Practicing_JWT.IRepository;
using Practicing_JWT.Model;

namespace Practicing_JWT.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("[controller]")]
    public class UserAuthController : ControllerBase
    {
        private readonly IUserAuthRepo _userAuthRepo;
        private readonly IOrderRepo _orderRepo;
        public UserAuthController(IUserAuthRepo user, IOrderRepo order)
        {
            _userAuthRepo = user;
            _orderRepo = order;
        }
        [HttpPost("Login")]
        public async Task<IActionResult> Login(UserDto authentication)
        {
            var data = await _userAuthRepo.Login(authentication);
            if (data == null)
                return BadRequest();
            return Ok(data);
        }
        [Authorize]
        [HttpPost("AddOrder")]
        public async Task<IActionResult> AddOrder(OrderDto orderDto)
        {
            var data = await _orderRepo.AddOrder(orderDto);
            return Ok(data);
        }
    }
}
