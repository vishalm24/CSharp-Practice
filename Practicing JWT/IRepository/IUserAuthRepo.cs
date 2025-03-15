using Practicing_JWT.Model;

namespace Practicing_JWT.IRepository
{
    public interface IUserAuthRepo
    {
        public Task<Object> Login(UserDto authentication);
    }
}
