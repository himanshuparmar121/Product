using Product.Data;
using Product.Schema.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Service
{
    public class ItemService 
    {
        private readonly ApplicationDbContext dbContext;

        public ItemService(ApplicationDbContext _dbContext)
        {
            this.dbContext = _dbContext; 
        }

        public void AddItem(Item item) 
        {
            dbContext.Items.Add(item);
        }

        public Item? GetItemById(int? id)
        {
            Item? item = dbContext.Items.Where(x => x.Id == id).FirstOrDefault();
            return item;
        }

        public IEnumerable<Item> GetAllItems()
        {
            dbContext.Items.ToList();
            return dbContext.Items;
        }

        public void Update(Item item)
        {
            Item? objItem = dbContext.Items.Where(x => x.Id == item.Id).FirstOrDefault();

            if (objItem != null)
            {
                objItem.Id = item.Id;
                objItem.Name = item.Name;
                objItem.UpdatedDate = DateTime.Now;
                objItem.UnitOfMeasure = item.UnitOfMeasure; 
            }

            dbContext.SaveChanges();

        }

        public void RemoveItem(int id)
        {
            Item? item = dbContext.Items.Where(x => x.Id == id).FirstOrDefault();

            if (item != null)
            {
                dbContext.Items.Remove(item);
            }
        }
    }
}
