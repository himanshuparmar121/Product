using Product.Data.IRepository;
using Product.Schema.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Data.Repository
{
    public class Item : IItemRepository
    {
        private readonly ApplicationDbContext ProductDbContext;

        public Item(ApplicationDbContext _dbContext)
        {
            ProductDbContext = _dbContext;
        }

        public void AddItem(Schema.Models.Item item)
        {
            ProductDbContext.Items.Add(item);
            ProductDbContext.SaveChanges();
        }

        public Schema.Models.Item? GetItemById(int id, int tenantId)
        {
            Schema.Models.Item? item = ProductDbContext.Items.Where(x => x.Id == id && x.TenantId == tenantId).FirstOrDefault();
            return item;
        }

        public IEnumerable<Schema.Models.Item> GetAllItems()
        {
            return ProductDbContext.Items.ToList();
        }

        public void Update(Schema.Models.Item item)
        {
            Schema.Models.Item? objItem = ProductDbContext.Items.Where(x => x.Id == item.Id && x.TenantId == item.TenantId).FirstOrDefault();

            if (objItem != null)
            {
                objItem.Id = item.Id;
                objItem.TenantId = item.TenantId;
                objItem.Name = item.Name;
                objItem.UpdatedDate = DateTime.Now;
                objItem.UnitOfMeasure = item.UnitOfMeasure;
                ProductDbContext.SaveChanges();
            }
        }

        public void RemoveItem(int id, int tenantId)
        {
            Schema.Models.Item? item = ProductDbContext.Items.Where(x => x.Id == id && x.TenantId == tenantId).FirstOrDefault();

            if (item != null)
            {
                ProductDbContext.Items.Remove(item);
                ProductDbContext.SaveChanges(true);
            }
        }

        public void DeleteItemByFlag(int id, int tenantId)
        {
            Schema.Models.Item? item = ProductDbContext.Items.Where(x => x.Id == id && x.TenantId == tenantId).FirstOrDefault();

            if (item != null)
            {
                item.IsDelete = true;
                ProductDbContext.SaveChanges(true);
            }
        }
    }
}
