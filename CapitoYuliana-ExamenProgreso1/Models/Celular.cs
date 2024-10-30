using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace CapitoYuliana_ExamenProgreso1.Models
{
    public class Celular
    {
        [Key]
        public int Id { get; set; }
        [StringLength(100)]
        public string Modelo { get; set; }
        [Range(2000,2025)]
        public int Anio { get; set; }
        public float Precio { get; set; }
    }
}
