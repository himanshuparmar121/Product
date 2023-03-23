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
        private int tenantId = 1;
        public ItemsController(IItemService itemService)
        {
            _itemService = itemService;
        }

        // GET: api/<ItemsController>
        [HttpGet("getAll")]
        public IActionResult GetAllItems()
        {
            return Ok(_itemService.GetAllItems(tenantId));
        }

        // GET api/<ItemsController>/5
        [HttpGet("getById")]
        public IActionResult GetItemById(int id)
        {
            return Ok(_itemService.GetItemById(id, tenantId));
        }

        // POST api/<ItemsController>
        [HttpPost("add")]
        public void AddItem(Schema.Models.Item item)
        {
            item.TenantId = tenantId;
            _itemService.AddItem(item);
        }

        // PUT api/<ItemsController>/5
        [HttpPost("update")]
        public void Update(Schema.Models.Item item)
        {
            item.TenantId = tenantId;
            _itemService.Update(item);
        }

        // DELETE api/<ItemsController>/5
        [HttpPost("remove")]
        public void RemoveItem(int id)
        {
            _itemService.RemoveItem(id, tenantId);
        }

        [HttpPost("delete")]
        public void softDelete(int id)
        {
            _itemService.DeleteItemByFlag(id, tenantId);
        }
    }
}
