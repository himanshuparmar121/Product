using Product.Data;
using Product.Data.IRepository;
using Product.Schema.Models;
using Product.Service.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Service.Services
{
    public class ItemObjectsService : IItemObjectsService
    {
        private ItemObjectsRepository _itemObjectsRepository;
        public ItemObjectsService(ItemObjectsRepository itemObjectsRepository)
        {
            _itemObjectsRepository = itemObjectsRepository;
        }
        public void AddItemObject(Schema.Models.ItemObjects itemObjects)
        {
            _itemObjectsRepository.AddItemObject(itemObjects);
        }

        public void DeleteItemObjectsByFlag(int id, int tenantId)
        {
            _itemObjectsRepository.DeleteItemObjectsByFlag(id, tenantId);
        }

        public IEnumerable<Schema.Models.ItemObjects> GetAllItemObjects(int tenantId)
        {
            return _itemObjectsRepository.GetAllItemObjects(tenantId);
        }

        public Schema.Models.ItemObjects? GetItemObjectsById(int id, int tenantId)
        {
            return _itemObjectsRepository.GetItemObjectsById(id, tenantId);
        }

        public void RemoveItemObject(int id, int tenantId)
        {
            _itemObjectsRepository.RemoveItemObject(id, tenantId);
        }

        public void Update(Schema.Models.ItemObjects itemObject)
        {
            _itemObjectsRepository.Update(itemObject);
        }
    }
}
