using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CapitoYuliana_ExamenProgreso1.Models;

namespace CapitoYuliana_ExamenProgreso1.Data
{
    public class CapitoYuliana_ExamenProgreso1Context : DbContext
    {
        public CapitoYuliana_ExamenProgreso1Context (DbContextOptions<CapitoYuliana_ExamenProgreso1Context> options)
            : base(options)
        {
        }

        public DbSet<CapitoYuliana_ExamenProgreso1.Models.Capito> Capito { get; set; } = default!;
        public DbSet<CapitoYuliana_ExamenProgreso1.Models.Celular> Celular { get; set; } = default!;
    }
}
