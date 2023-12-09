

namespace Users.Data.IRepository
{
    public interface IUserDetailRepository
    {
        void AddUserDetail(Schema.Models.UserDetail UserDetail);
        Schema.Models.UserDetail? GetUserDetailById(int id);
        IEnumerable<Schema.Models.UserDetail> GetAllUserDetails();
        void Update(Schema.Models.UserDetail UserDetail);
    }
}
