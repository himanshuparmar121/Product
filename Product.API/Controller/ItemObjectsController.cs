using Microsoft.AspNetCore.Mvc;
using Product.DbMigrations.Migrations;
using Product.Service.IServices;

namespace Product.API.Controller
{
    [Route("[controller]")]
    [ApiController]
    public class ItemObjectsController : ControllerBase
    {
        private readonly IItemObjectsService _itemObjectsService;
        private int tenantId = 1;

        public ItemObjectsController(IItemObjectsService itemObjectsService)
        {
            _itemObjectsService = itemObjectsService;
        }

        [HttpGet("getAll")]
        public IActionResult GetAllItemObjects()
        {
            return Ok(_itemObjectsService.GetAllItemObjects(tenantId));
        }

        [HttpGet("getById")]
        public IActionResult GetItemObjectsById(int id)
        {
            return Ok(_itemObjectsService.GetItemObjectsById(id, tenantId));
        }

        [HttpPost("addItemObject")]
        public void AddItemObject(Schema.Models.ItemObjects itemObject)
        {
            itemObject.TenantId = tenantId;
            _itemObjectsService.AddItemObject(itemObject);
        }

        [HttpPost("update")]
        public void Update(Schema.Models.ItemObjects itemObject)
        {
            itemObject.TenantId = tenantId;
            _itemObjectsService.Update(itemObject);
        }

        [HttpPost("remove")]
        public void RemoveItemObject(int id)
        {
            _itemObjectsService.RemoveItemObject(id, tenantId);
        }

        [HttpPost("delete")]
        public void softDelete(int id)
        {
            _itemObjectsService.DeleteItemObjectsByFlag(id, tenantId);
        }
    }
}
