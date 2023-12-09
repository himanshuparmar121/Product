using Users.Data.IRepository;
using Users.Data.Repository;
using Users.Service.IServices;
using Users.Service.Services;

namespace Users.API.Helpers
{
    public class Dependencies
    {
        public static void Dependency(IServiceCollection services)
        {
            services.AddTransient<IUserDetailService, UserDetailService>();
            services.AddTransient<IUserDetailRepository, UserDetail>();
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IUserRepository, User>();
        }
    }
}
