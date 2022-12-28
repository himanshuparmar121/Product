using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Data
{
    public class ItemObjects
    {
        private readonly ApplicationDbContext ProductDbContext;

        public ItemObjects(ApplicationDbContext _dbContext)
        {
            ProductDbContext = _dbContext;
        }

        public void AddItemObject(Schema.Models.ItemObjects itemObjects)
        {
            ProductDbContext.ItemObjects.Add(itemObjects);
            ProductDbContext.SaveChanges();
        }

        public Schema.Models.ItemObjects? GetItemObjectsById(int id, int tenantId)
        {
            Schema.Models.ItemObjects? itemobject = ProductDbContext.ItemObjects.Where(x => x.Id == id && x.TenantId == tenantId).FirstOrDefault();

            return itemobject;
        }

        public IEnumerable<Schema.Models.ItemObjects> GetAllItemObjects()
        {
            return ProductDbContext.ItemObjects.ToList();
        }

        public void Update(Schema.Models.ItemObjects itemObject)
        {
            Schema.Models.ItemObjects? item = ProductDbContext.ItemObjects.Where(x => x.Id == itemObject.Id && x.TenantId == itemObject.TenantId).FirstOrDefault();

            if (item != null)
            {
                item.Id = itemObject.Id;
                item.TenantId = itemObject.TenantId;
                item.ItemId = itemObject.ItemId;
                item.ParentItem = itemObject.ParentItem;
                item.ParentItemIdItemId = itemObject.ParentItemIdItemId;
                item.UpdatedDate = DateTime.Now;
                item.Quantity = itemObject.Quantity;
                ProductDbContext.SaveChanges();
            }
        }

        public void RemoveItemObject(int id, int tenantId)
        {
            Schema.Models.ItemObjects? item = ProductDbContext.ItemObjects.Where(x => x.Id == id && x.TenantId == tenantId).FirstOrDefault();

            if (item != null)
            {
                ProductDbContext.ItemObjects.Remove(item);
                ProductDbContext.SaveChanges();
            }
        }

        public void DeleteItemObjectsByFlag(int id, int tenantId)
        {
            Schema.Models.ItemObjects? item = ProductDbContext.ItemObjects.Where(x => x.Id == id && x.TenantId == tenantId).FirstOrDefault();

            if (item != null)
            {
                item.IsDelete = true;
                ProductDbContext.SaveChanges(true);
            }
        }
    }
}
