using Microsoft.AspNetCore.Mvc;
using Product.Service.IServices;

namespace Product.API.Controller
{
    [Route("[controller]")]
    [ApiController]
    public class ItemObjectsController : ControllerBase
    {
        private readonly IItemObjectsService _itemObjectsService;

        public ItemObjectsController(IItemObjectsService itemObjectsService)
        {
            _itemObjectsService = itemObjectsService;
        }

        [HttpGet("getAll")]
        public IActionResult GetAllItemObjects()
        {
            return Ok(_itemObjectsService.GetAllItemObjects());
        }

        [HttpGet("getById")]
        public IActionResult GetItemObjectsById(int id, int tenantId)
        {
            return Ok(_itemObjectsService.GetItemObjectsById(id, tenantId));
        }

        [HttpPost("addItemObject")]
        public void AddItemObject(Schema.Models.ItemObjects itemObject)
        {
            _itemObjectsService.AddItemObject(itemObject);
        }

        [HttpPost("update")]
        public void Update(Schema.Models.ItemObjects itemObject)
        {
            _itemObjectsService.Update(itemObject);
        }

        [HttpPost("remove")]
        public void RemoveItemObject(int id, int tenantId)
        {
            _itemObjectsService.RemoveItemObject(id, tenantId);
        }

        [HttpPost("deleteItemObjectByFlag")]
        public void DeleteItemObjectByFlag(int id, int tenantId)
        {
            _itemObjectsService.DeleteItemObjectsByFlag(id, tenantId);
        }
    }
}
