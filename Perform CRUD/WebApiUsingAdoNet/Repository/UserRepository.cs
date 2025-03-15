using System.Data;
using WebApiUsingAdoNet.Data;
using WebApiUsingAdoNet.IRepository;
using WebApiUsingAdoNet.Model.DTO;

namespace WebApiUsingAdoNet.Repository
{
    public class UserRepository : IUserRepo
    {
        private readonly DatabaseHelper _dbHelper;
        public UserRepository(DatabaseHelper dbHelper)
        {
            _dbHelper = dbHelper;
        }
        public IEnumerable<UserDto> GetUsers()
        {
            var query = "SELECT * FROM users WHERE IsActive = 1";
            //var query = "SELECT * FROM users";
            DataTable dt = _dbHelper.ExecuteQuery(query);
            List<UserDto> users = new List<UserDto>();
            foreach (DataRow row in dt.Rows)
            {
                var user = new UserDto
                {
                    Id = (Guid)row["Id"],
                    FirstName = (string)row["FirstName"],
                    LastName = (string)row["LastName"],
                    PhoneNumber = (string)row["PhoneNumber"],
                    Email = (string)row["Email"],
                    Address = (string)row["Address"]
                };
                users.Add(user);
            }
            return users;
        }
    }
}
