﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Data.IRepository
{
    public interface IItemRepository
    {
        void AddItem(Schema.Models.Item item);
        Schema.Models.Item? GetItemById(int id, int tenantId);
        IEnumerable<Schema.Models.Item> GetAllItems();
        void Update(Schema.Models.Item item);
        void RemoveItem(int id, int tenantId);
        void DeleteItemByFlag(int id, int tenantId);

    }
}
