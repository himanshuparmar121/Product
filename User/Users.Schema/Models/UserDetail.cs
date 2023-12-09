using System.ComponentModel.DataAnnotations;


namespace Users.Schema.Models
{
    public class UserDetail
    {
        [Key]
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string ContactNo { get; set; }
        public string ContactEmail { get; set; }
    }
}
