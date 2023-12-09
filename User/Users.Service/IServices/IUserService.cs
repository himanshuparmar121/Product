

using Users.Schema.DTOs;

namespace Users.Service.IServices
{
    public interface IUserService
    {
        string AddUser(UserDto User, int tenantId);
        Schema.Models.User? GetUserById(int id, int tenantId);
        IEnumerable<Schema.Models.User> GetAllUsers(int tenantId);
        string Update(Schema.Models.User user);
        void RemoveUser(int id, int tenantId);
        void DeleteUserByFlag(int id, int tenantId);
    }
}
