using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Data
{
    public class ItemObjects
    {
        private readonly ApplicationDbContext dbContext;

        public ItemObjects(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void AddItemObject(Schema.Models.ItemObjects itemObjects)
        {
            dbContext.ItemObjects.Add(itemObjects);
            dbContext.SaveChanges();
        }

        public Schema.Models.ItemObjects? GetItemObjectsById(int? id, int? tenantId)
        {
            Schema.Models.ItemObjects? itemobject = dbContext.ItemObjects.Where(x => x.Id == id && x.TenantId == tenantId).FirstOrDefault();

            return itemobject;
        }

        public IEnumerable<Schema.Models.ItemObjects> GetAllItemObjects()
        {
            return dbContext.ItemObjects.ToList();
        }

        public void Update(Schema.Models.ItemObjects itemObject)
        {
            Schema.Models.ItemObjects? item = dbContext.ItemObjects.Where(x => x.Id == itemObject.Id && x.TenantId == itemObject.TenantId).FirstOrDefault();

            if (item != null)
            {
                item.Id = itemObject.Id;
                item.TenantId = itemObject.TenantId;
                item.ItemId = itemObject.ItemId;
                item.ParentItem = itemObject.ParentItem;
                item.ParentItemIdItemId = itemObject.ParentItemIdItemId;
                item.UpdatedDate = DateTime.Now;
                item.Quantity = itemObject.Quantity;
            }

            dbContext.SaveChanges();
        }

        public void RemoveItemObject(int id, int tenantId)
        {
            Schema.Models.ItemObjects? item = dbContext.ItemObjects.Where(x => x.Id == id && x.TenantId == tenantId).FirstOrDefault();

            if (item != null)
            {
                dbContext.ItemObjects.Remove(item);
            }
            dbContext.SaveChanges();
        }
    }
}
