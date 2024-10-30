using System.ComponentModel.DataAnnotations;

namespace CapitoYuliana_ExamenProgreso1.Models
{
    public class Capito
    {
        [Key]
        public int Cedula { get; set; }
        [Required]
        [StringLength(120)]
        public string Nombre { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Range(0,120)]
        public int Edad { get; set; }
        public float Altura { get; set; }
        public bool MayorDeEdad { get; set; }

    }
}
