
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models
{
    public class User

    {
        [Key]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public DateTime UpdateDate { get; set; } = DateTime.Now;

        public int RoleId { get; set; }
    

    }
}
