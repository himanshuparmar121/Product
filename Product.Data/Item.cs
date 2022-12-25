using Product.Schema.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Data
{
    public class Item
    {
        private readonly ApplicationDbContext dbContext;

        public Item(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void AddItem(Schema.Models.Item item)
        {
            dbContext.Items.Add(item);
            dbContext.SaveChanges();
        }

        public Schema.Models.Item? GetItemById(int? id, int? tenantId)
        {
            Schema.Models.Item? item = dbContext.Items.Where(x => x.Id == id && x.TenantId == tenantId).FirstOrDefault();
            return item;
        }

        public IEnumerable<Schema.Models.Item> GetAllItems()
        {
            return dbContext.Items.ToList();
        }

        public void Update(Schema.Models.Item item)
        {
            Schema.Models.Item? objItem = dbContext.Items.Where(x => x.Id == item.Id && x.TenantId == item.TenantId).FirstOrDefault();

            if (objItem != null)
            {
                objItem.Id = item.Id;
                objItem.TenantId = item.TenantId;
                objItem.Name = item.Name;
                objItem.UpdatedDate = DateTime.Now;
                objItem.UnitOfMeasure = item.UnitOfMeasure;
            }
            dbContext.SaveChanges();
        }

        public void RemoveItem(int id, int tenantId)
        {
            Schema.Models.Item? item = dbContext.Items.Where(x => x.Id == id && x.TenantId == tenantId).FirstOrDefault();

            if (item != null)
            {
                dbContext.Items.Remove(item);
            }
            dbContext.SaveChanges(true);
        }
    }
}
