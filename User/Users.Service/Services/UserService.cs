using Users.Data.IRepository;
using Users.Service.IServices;

namespace Users.Service.Services
{
    public class UserService : IUserService
    {
        private IUserRepository _UsersRepository;
        private IUserDetailRepository _UsersDetailRepository;
        public UserService(IUserRepository UsersRepository, IUserDetailRepository usersDetailRepository)
        {
            _UsersRepository = UsersRepository;
            _UsersDetailRepository = usersDetailRepository; 
        }

        public string AddUser(Schema.DTOs.UserDto User, int tenantId)
        {
            if (User != null)
            {
                if (!string.IsNullOrEmpty(User.UserName))
                {
                    if (!_UsersRepository.CheckUserName(User.UserName, tenantId))
                    {
                        return "User Name already exists";
                    }
                }

                Schema.Models.User user = new Schema.Models.User();
                user.UserName = User.UserName;
                user.Password = User.Password;
                user.TenantId = tenantId;
                _UsersRepository.AddUser(user);

                int userId = _UsersRepository.GetUserIdByUserName(user.UserName, user.TenantId);

                Schema.Models.UserDetail userDetail = new Schema.Models.UserDetail();
                if (userId > 0)
                {
                    userDetail.UserId = userId;
                    userDetail.FirstName = User.FirstName;
                    userDetail.MiddleName = User.MiddleName;
                    userDetail.LastName = User.LastName;
                    userDetail.ContactEmail = User.ContactEmail;
                    userDetail.ContactNo = User.ContactNo;

                    _UsersDetailRepository.AddUserDetail(userDetail);

                    return "success";
                }
                else
                {
                    return "failed";
                }
            }
            else
            {
                return "Mandatory fields missing";
            }
        }

        public void DeleteUserByFlag(int id, int tenantId)
        {
            _UsersRepository.DeleteUserByFlag(id, tenantId);
        }

        public IEnumerable<Schema.Models.User> GetAllUsers(int tenantId)
        {
            return _UsersRepository.GetAllUsers(tenantId);
        }

        public Schema.Models.User? GetUserById(int id, int tenantId)
        {
            return _UsersRepository.GetUserById(id, tenantId);
        }

        public void RemoveUser(int id, int tenantId)
        {
            _UsersRepository.RemoveUser(id, tenantId);
        }

        public string Update(Schema.Models.User User)
        {
            if (User != null)
            {
                Schema.Models.User user = new Schema.Models.User();
                user.UserName = User.UserName;
                
                if (!string.IsNullOrEmpty(User.UserName))
                {
                    if (!_UsersRepository.CheckUserName(User.UserName, User.TenantId))
                    {
                        return "User Name already exists";
                    }
                }

                _UsersRepository.Update(user);

                return "User Updated successfully";
            }

            return "Not Valid";
        }
    }
}
