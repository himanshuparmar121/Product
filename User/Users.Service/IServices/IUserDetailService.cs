

namespace Users.Service.IServices
{
    public interface IUserDetailService
    {
        void AddUserDetail(Schema.Models.UserDetail userDetail);
        Schema.Models.UserDetail? GetUserDetailById(int id);
        IEnumerable<Schema.Models.UserDetail> GetAllUserDetails();
        void Update(Schema.Models.UserDetail userDetail);
    }
}
