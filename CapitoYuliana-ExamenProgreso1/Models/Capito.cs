﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        [Required]
        public float Altura { get; set; }
        [Required]
        public bool MayorDeEdad { get; set; }
        [Required]
        public Celular? celular { get; set; }

        [ForeignKey("Celular")]
        public int idCelular { get; protected set; }


    }
}
