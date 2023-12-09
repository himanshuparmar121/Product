using System;
using System.ComponentModel.DataAnnotations;


namespace Users.Schema.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public int TenantId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public char Status { get; set; }
        public DateTime? DeactivationDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; } = DateTime.Now;
        public int UpdatedBy { get; set; }
        public DateTime? UpdationDate { get; set; }
        public bool IsDelete { get; set; }
    }
}
