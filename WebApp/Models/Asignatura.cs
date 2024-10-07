using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class Asignatura
    {
        [Key]
        public int Id { get; set; } 
        public string Nombre { get; set; }
        public string Profesor { get; set; }
        public int Creditos { get; set; } 
        public int Cuatrimestre { get; set; }
        

    }
}
