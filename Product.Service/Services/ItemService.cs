using Microsoft.EntityFrameworkCore;
using Product.Data;
using Product.Data.IRepository;
using Product.Data.Repository;
using Product.Schema.Models;
using Product.Service.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Service.Services
{
    public class ItemService : IItemService
    {
        private IItemRepository _itemRepository;
        public ItemService(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }
        public void AddItem(Schema.Models.Item item)
        {
            _itemRepository.AddItem(item);
        }

        public void DeleteItemByFlag(int id, int tenantId)
        {
            _itemRepository.DeleteItemByFlag(id, tenantId);
        }

        public IEnumerable<Schema.Models.Item> GetAllItems(int tenantId)
        {
            return _itemRepository.GetAllItems(tenantId);
        }

        public Schema.Models.Item? GetItemById(int id, int tenantId)
        {
            return _itemRepository.GetItemById(id, tenantId);
        }

        public void RemoveItem(int id, int tenantId)
        {
            _itemRepository.RemoveItem(id, tenantId);
        }

        public void Update(Schema.Models.Item item)
        {
            _itemRepository.Update(item);
        }
    }
}
