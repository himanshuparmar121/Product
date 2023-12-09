using Microsoft.AspNetCore.Mvc;
using Users.Service.IServices;

namespace Users.API.Controller
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private int tenantId = 1;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("getAll")]
        public IActionResult GetAllUser()
        {
            return Ok(_userService.GetAllUsers(tenantId));
        }

        [HttpGet("getById")]
        public IActionResult GetUserById(int id)
        {
            return Ok(_userService.GetUserById(id, tenantId));
        }

        [HttpPost("addUser")]
        public string AddUser(Schema.DTOs.UserDto itemObject)
        {
            return(_userService.AddUser(itemObject, tenantId = 1));
        }

        [HttpPost("update")]
        public void Update(Schema.Models.User itemObject)
        {
            itemObject.TenantId = tenantId;
            _userService.Update(itemObject);
        }

        [HttpPost("remove")]
        public void RemoveUser(int id)
        {
            _userService.RemoveUser(id, tenantId);
        }

        [HttpPost("delete")]
        public void softDelete(int id)
        {
            _userService.DeleteUserByFlag(id, tenantId);
        }
    }
}
