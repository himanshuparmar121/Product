
namespace Users.Data.IRepository
{
    public interface IUserRepository
    {
        void AddUser(Schema.Models.User User);
        Schema.Models.User? GetUserById(int id, int tenantId);
        IEnumerable<Schema.Models.User> GetAllUsers(int tenantId);
        void Update(Schema.Models.User User);
        void RemoveUser(int id, int tenantId);
        void DeleteUserByFlag(int id, int tenantId);
        int GetUserIdByUserName(string userName, int tenantId);
        bool CheckUserName(string userName, int tenantId);
    }
}
