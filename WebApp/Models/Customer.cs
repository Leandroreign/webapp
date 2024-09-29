using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; } 
        public string CustomerName { get; set; } 
        public string IdentificationCard { get; set; } 
        public string? PhoneNumber { get; set; } 
        public bool Active { get; set; } 
        public DateTime UpdateDate { get; set; } = DateTime.Now;
        

    }
}
