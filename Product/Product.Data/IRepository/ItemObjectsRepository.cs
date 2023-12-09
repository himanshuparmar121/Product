﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Data.IRepository
{
    public interface ItemObjectsRepository
    {
        void AddItemObject(Schema.Models.ItemObjects itemObjects);
        Schema.Models.ItemObjects? GetItemObjectsById(int id, int tenantId);
        IEnumerable<Schema.Models.ItemObjects> GetAllItemObjects(int tenantId);
        void Update(Schema.Models.ItemObjects itemObject);
        void RemoveItemObject(int id, int tenantId);
        void DeleteItemObjectsByFlag(int id, int tenantId);
    }
}