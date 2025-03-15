using Microsoft.AspNetCore.Mvc;
using System.Data;
using WebApiUsingAdoNet.Data;
using WebApiUsingAdoNet.IRepository;
using WebApiUsingAdoNet.Model;

namespace WebApiUsingAdoNet.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        //private readonly DatabaseHelper _dbHelper;
        //public UserController(DatabaseHelper dbHelper)
        //{
        //    _dbHelper = dbHelper;
        //}
        private readonly IUserRepo _userRepo;
        public UserController(IUserRepo userRepo)
        {
            _userRepo = userRepo;
        }
        [HttpGet]
        public IActionResult GetUsers()
        {
            var users = _userRepo.GetUsers();
            return Ok(users);
        }
    }
}
