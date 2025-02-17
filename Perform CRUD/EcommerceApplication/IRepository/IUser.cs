using EcommerceApplication.Model;
using EcommerceApplication.Model.Dto;

namespace EcommerceApplication.IRepository
{
    public interface IUser
    {
        public Task<IEnumerable<UserDto>> GetUsers();
        public Task<UserDto> GetUserById(Guid id);
        public Task<UserDto> AddUser(UserAddDto user);
        public Task<UserDto> DeleteUser(Guid id);
        public Task<UserDto> UpdateUser(UserUpdateDto userDto);
    }
}
