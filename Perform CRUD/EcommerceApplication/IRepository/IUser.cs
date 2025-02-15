using EcommerceApplication.Model;
using EcommerceApplication.Model.Dto;

namespace EcommerceApplication.IRepository
{
    public interface IUser
    {
        public Task<IEnumerable<UserDto>> GetUsers();
        public Task<UserDto> GetUserById(Guid id);
        public Task AddUser(UserAddDto user);
        public Task<bool> DeleteUser(Guid id);
        public Task UpdateUser(User user);
    }
}
