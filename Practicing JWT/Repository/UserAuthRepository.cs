using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Practicing_JWT.Data;
using Practicing_JWT.IRepository;
using Practicing_JWT.Model;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Practicing_JWT.Repository
{
    public class UserAuthRepository :  IUserAuthRepo
    {
        private readonly ApplicationDbContext _context;
        private readonly IConfiguration _configuration;
        public UserAuthRepository(ApplicationDbContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }
        public async Task<Object> Login(UserDto authentication)
        {

            var user = await _context.Auth.FirstOrDefaultAsync(a => a.Email == authentication.Email && a.Password == authentication.Password);
            if (user != null)
            {
                var claims = new[]
                {
                    new Claim(JwtRegisteredClaimNames.Sub, _configuration["Jwt:Subject"]),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                    new Claim("UserEmail", authentication.Email.ToString()) 
                };
                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
                var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                var token = new JwtSecurityToken(
                    _configuration["Jwt:Issuer"],
                    _configuration["Jwt:Audience"],
                    claims: claims,
                    expires: DateTime.UtcNow.AddMinutes(10),
                    signingCredentials: signIn
                    );
                string tokenValue = new JwtSecurityTokenHandler().WriteToken(token);
                return new { Token = tokenValue, User = user };
            }
            return false;
        }
    }
}
