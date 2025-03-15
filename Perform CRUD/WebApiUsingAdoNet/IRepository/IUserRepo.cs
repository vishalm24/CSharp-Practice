using WebApiUsingAdoNet.Model.DTO;

namespace WebApiUsingAdoNet.IRepository
{
    public interface IUserRepo
    {
        public IEnumerable<UserDto> GetUsers();
    }
}
