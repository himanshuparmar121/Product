using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Users.Data.IRepository;
using Users.Schema.Models;
using Users.Service.IServices;

namespace Users.Service.Services
{
    public class UserDetailService : IUserDetailService
    {
        private IUserDetailRepository _userDetailRepository;
        public UserDetailService(IUserDetailRepository userDetailRepository)
        {
            _userDetailRepository = userDetailRepository;
        }

        public void AddUserDetail(UserDetail userDetail)
        {
            _userDetailRepository.AddUserDetail(userDetail);
        }

        public IEnumerable<UserDetail> GetAllUserDetails()
        {
            return _userDetailRepository.GetAllUserDetails();
        }

        public UserDetail? GetUserDetailById(int id)
        {
            return _userDetailRepository.GetUserDetailById(id);
        }

        public void Update(UserDetail userDetail)
        {
            _userDetailRepository.Update(userDetail);
        }
    }
}
