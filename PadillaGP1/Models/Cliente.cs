using System.ComponentModel.DataAnnotations;

namespace PadillaGP1.Models
{
    public class Cliente
    {
        [Key]
        public int ClienteId { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(100, ErrorMessage = "El nombre no puede exceder los 100 caracteres")]
        public string Nombre { get; set; }

        [Range(0, 10000, ErrorMessage = "El saldo debe estar entre 0 y 10,000")]
        public decimal Saldo { get; set; }

        public bool EsVip { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Fecha de Nacimiento")]
        public DateTime FechaNacimiento { get; set; }

        // Relación
        public ICollection<Reserva> Reservas { get; set; }
    }

}
