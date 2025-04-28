using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PadillaGP1.Models;

namespace PadillaGP1.Data
{
    public class PadillaGP1Context : DbContext
    {
        public PadillaGP1Context (DbContextOptions<PadillaGP1Context> options)
            : base(options)
        {
        }

        public DbSet<PadillaGP1.Models.Cliente> Cliente { get; set; } = default!;
        public DbSet<PadillaGP1.Models.Reserva> Reserva { get; set; } = default!;
        public DbSet<PadillaGP1.Models.PlanDeRecompensas> PlanDeRecompensas { get; set; } = default!;
    }
}
