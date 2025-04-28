using Microsoft.EntityFrameworkCore;
using PadillaGP1.Models;

namespace PadillaGP1.Data
{
    public class PadillaGP1Context : DbContext
    {
        public PadillaGP1Context(DbContextOptions<PadillaGP1Context> options)
            : base(options)
        {
        }

        public DbSet<PadillaGP1.Models.Cliente> Cliente { get; set; }
        public DbSet<PadillaGP1.Models.Reserva> Reserva { get; set; }
        public DbSet<PadillaGP1.Models.PlanDeRecompensas> PlanDeRecompensas { get; set; }

      
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

          
            modelBuilder.Entity<Cliente>()
                .Property(c => c.Saldo)
                .HasPrecision(18, 2);  

            modelBuilder.Entity<Reserva>()
                .Property(r => r.ValorPagar)
                .HasPrecision(18, 2);  
        }
    }
}
