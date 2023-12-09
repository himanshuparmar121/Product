using Users.Data.IRepository;

namespace Users.Data.Repository
{
    public class UserDetail : IUserDetailRepository
    {
        private readonly ApplicationDbContext UserDbContext;

        public UserDetail(ApplicationDbContext _dbContext)
        {
            UserDbContext = _dbContext;
        }

        public void AddUserDetail(Schema.Models.UserDetail userDetail)
        {
            UserDbContext.UserDetails.Add(userDetail);
            UserDbContext.SaveChanges();
        }

        public Schema.Models.UserDetail? GetUserDetailById(int id)
        {
            Schema.Models.UserDetail? userDetail = UserDbContext.UserDetails.Where(x => x.UserId == id).FirstOrDefault();
            return userDetail;
        }

        public IEnumerable<Schema.Models.UserDetail> GetAllUserDetails()
        {
            return UserDbContext.UserDetails.ToList();
        }

        public void Update(Schema.Models.UserDetail userDetail)
        {
            Schema.Models.UserDetail? objuserDetail = UserDbContext.UserDetails.Where(x => x.UserId == userDetail.UserId).FirstOrDefault();

            if (objuserDetail != null)
            {
                objuserDetail.FirstName = userDetail.FirstName;
                objuserDetail.MiddleName = userDetail.MiddleName;
                objuserDetail.LastName = userDetail.LastName;
                objuserDetail.ContactEmail = userDetail.ContactEmail;
                objuserDetail.ContactNo = userDetail.ContactNo;
                UserDbContext.SaveChanges();
            }
        }
    }
}
