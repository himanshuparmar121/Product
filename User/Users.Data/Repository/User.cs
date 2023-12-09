using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Users.Data;
using Users.Data.IRepository;

namespace Users.Data.Repository
{
    public class User : IUserRepository
    {
        private readonly ApplicationDbContext UserDbContext;

        public User(ApplicationDbContext _dbContext)
        {
            UserDbContext = _dbContext;
        }

        public void AddUser(Schema.Models.User Users)
        {
            UserDbContext.Users.Add(Users);
            UserDbContext.SaveChanges();
        }

        public void Update(Schema.Models.User User)
        {
            Schema.Models.User? user = UserDbContext.Users.Where(x => x.UserId == User.UserId && x.TenantId == User.TenantId).FirstOrDefault();

            if (user != null)
            {
                
                UserDbContext.SaveChanges();
            }
        }

        public void RemoveUser(int id, int tenantId)
        {
            Schema.Models.User? user = UserDbContext.Users.Where(x => x.UserId == id && x.TenantId == tenantId).FirstOrDefault();

            if (user != null)
            {
                UserDbContext.Users.Remove(user);
                UserDbContext.SaveChanges();
            }
        }

        public Schema.Models.User? GetUserById(int id, int tenantId)
        {
            Schema.Models.User? User = UserDbContext.Users.Where(x => x.UserId == id && x.TenantId == tenantId).FirstOrDefault();

            return User;
        }

        public IEnumerable<Schema.Models.User> GetAllUsers(int tenantId)
        {
            return UserDbContext.Users.Where(x => x.TenantId == tenantId).ToList();
        }

        public void DeleteUserByFlag(int id, int tenantId)
        {
            Schema.Models.User? user = UserDbContext.Users.Where(x => x.UserId == id && x.TenantId == tenantId).FirstOrDefault();

            if (user != null)
            {
                user.IsDelete = true;
                UserDbContext.SaveChanges(true);
            }
        }

        public int GetUserIdByUserName(string userName, int tenantId)
        {
            Schema.Models.User? user = UserDbContext.Users.Where(x => x.UserName == userName && x.TenantId == tenantId).FirstOrDefault();

            if (user != null)
            {
                return user.UserId;
            }
            else
            {
                return 0;
            }
        }

        public bool CheckUserName(string userName, int tenantId)
        {
            Schema.Models.User? user = UserDbContext.Users.Where(x => x.UserName == userName && x.TenantId == tenantId).FirstOrDefault();

            if (user != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }   
    }
}
