using Microsoft.EntityFrameworkCore;
using Product.Data;
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
        private readonly ApplicationDbContext ProductDbContext;
        Data.Item Item;
        public ItemService(ApplicationDbContext _dbContext)
        {
            ProductDbContext = _dbContext;
            if (ProductDbContext != null)
            {
                Item = new Data.Item(ProductDbContext);
            }
        }
        public void AddItem(Schema.Models.Item item)
        {
            Item.AddItem(item);
        }

        public void DeleteItemByFlag(int id, int tenantId)
        {
            Item.DeleteItemByFlag(id, tenantId);
        }

        public IEnumerable<Schema.Models.Item> GetAllItems()
        {
            return Item.GetAllItems();
        }

        public Schema.Models.Item? GetItemById(int id, int tenantId)
        {
            return Item.GetItemById(id, tenantId);
        }

        public void RemoveItem(int id, int tenantId)
        {
            Item.RemoveItem(id, tenantId);
        }

        public void Update(Schema.Models.Item item)
        {
            Item.Update(item);
        }
    }
}
