using Microsoft.AspNetCore.Mvc;
using Users.Service.IServices;

namespace Users.API.Controller
{
    [Route("[controller]")]
    [ApiController]
    public class UserDetailsController : ControllerBase
    {
        private readonly IUserDetailService _userDetailService;
        private int tenantId = 1;
        public UserDetailsController(IUserDetailService userDetailService)
        {
            _userDetailService = userDetailService;
        }

        // GET: api/<UserDetailsController>
        [HttpGet("getAll")]
        public IActionResult GetAllUserDetails()
        {
            return Ok(_userDetailService.GetAllUserDetails());
        }

        // GET api/<UserDetailsController>/5
        [HttpGet("getById")]
        public IActionResult GetUserDetailById(int id)
        {
            return Ok(_userDetailService.GetUserDetailById(id));
        }

        // POST api/<UserDetailsController>
        [HttpPost("add")]
        public void AddUserDetail(Schema.Models.UserDetail userDetail)
        {
            _userDetailService.AddUserDetail(userDetail);
        }

        // PUT api/<UserDetailsController>/5
        [HttpPost("update")]
        public void Update(Schema.Models.UserDetail userDetail)
        {
            _userDetailService.Update(userDetail);
        }
    }
}
