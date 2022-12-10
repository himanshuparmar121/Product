using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Product.Schema.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }
        public int TenantId { get; set; }
        public string UniqueId { get; set; }
        public string Name { get; set; }
        public double Quantity { get; set; }
        public long LotNumber { get; set; }
        public string UnitOfMeasure { get; set; }
        public bool IsActive { get; set; }
        public DateTime? ManufacturingDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public DateTime? CreatedDate { get; set; } = DateTime.Now;
        public bool IsDelete { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
