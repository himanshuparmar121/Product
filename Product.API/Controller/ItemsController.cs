using Microsoft.AspNetCore.Mvc;
using Product.Schema.Models;
using Product.Service.IServices;

namespace Product.API.Controller
{
    [Route("[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private readonly IItemService _itemService;

        public ItemsController(IItemService itemService)
        {
            _itemService = itemService;
        }

        // GET: api/<ItemsController>
        [HttpGet("getAll")]
        public IActionResult GetAllItems(int tenantId)
        {
            return Ok(_itemService.GetAllItems(tenantId));
        }

        // GET api/<ItemsController>/5
        [HttpGet("getById")]
        public IActionResult GetItemById(int id, int tenantId)
        {
            return Ok(_itemService.GetItemById(id, tenantId));
        }

        // POST api/<ItemsController>
        [HttpPost("add")]
        public void AddItem(Schema.Models.Item item)
        {
            _itemService.AddItem(item);
        }

        // PUT api/<ItemsController>/5
        [HttpPost("update")]
        public void Update(Schema.Models.Item item)
        {
            _itemService.Update(item);
        }

        // DELETE api/<ItemsController>/5
        [HttpPost("remove")]
        public void RemoveItem(int id, int tenantId)
        {
            _itemService.RemoveItem(id, tenantId);
        }

        [HttpPost("delete")]
        public void softDelete(int id, int tenantId)
        {
            _itemService.DeleteItemByFlag(id, tenantId);
        }
    }
}
