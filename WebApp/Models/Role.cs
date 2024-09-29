using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class Role
    {
        [Key]
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public DateTime UpdateDate { get; set; } = DateTime.Now;
    }
}
