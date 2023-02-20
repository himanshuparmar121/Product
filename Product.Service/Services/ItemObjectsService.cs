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
    public class ItemObjectsService : IItemObjectsService
    {
        private readonly ApplicationDbContext ProductDbContext;
        Data.ItemObjects ItemObject;
        public ItemObjectsService(ApplicationDbContext _dbContext)
        {
            ProductDbContext = _dbContext;
            if (ProductDbContext != null)
            {
                ItemObject = new Data.ItemObjects(ProductDbContext);
            }
        }
        public void AddItemObject(Schema.Models.ItemObjects itemObjects)
        {
            ItemObject.AddItemObject(itemObjects);
        }

        public void DeleteItemObjectsByFlag(int id, int tenantId)
        {
            ItemObject.DeleteItemObjectsByFlag(id, tenantId);
        }

        public IEnumerable<Schema.Models.ItemObjects> GetAllItemObjects()
        {
            return ItemObject.GetAllItemObjects();
        }

        public Schema.Models.ItemObjects? GetItemObjectsById(int id, int tenantId)
        {
            return ItemObject.GetItemObjectsById(id, tenantId);
        }

        public void RemoveItemObject(int id, int tenantId)
        {
            ItemObject.RemoveItemObject(id, tenantId);
        }

        public void Update(Schema.Models.ItemObjects itemObject)
        {
            ItemObject.Update(itemObject);
        }
    }
}
