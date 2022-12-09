using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Product.Models
{
    public class ItemObjects
    {
        [Key]
        public int Id { get; set; }
        public int? ParentItemId { get; set; }
        [ForeignKey("ParentProductId")]
        public virtual Item ParentItem { get; set; }
        public int? ItemId { get; set; }
        [ForeignKey("ProductId")]
        public virtual Item Item { get; set; }
        public int TenantId { get; set; }
        public double Quantity { get; set; }
        public bool IsActive { get; set; }
        public DateTime? CreatedDate { get; set; } = DateTime.Now;
        public bool IsDelete { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
