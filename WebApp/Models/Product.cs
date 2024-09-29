using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public bool Active { get; set; }
        public DateTime UpdateDate { get; set; } = DateTime.Now;


    }
}
