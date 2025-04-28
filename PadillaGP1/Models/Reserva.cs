using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace PadillaGP1.Models
{
    public class Reserva
    {
        [Key]
        public int Id { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "La fecha de entrada es obligatoria.")]
        public DateTime FechaEntrada { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "La fecha de salida es obligatoria.")]
        public DateTime FechaSalida { get; set; }

        [DataType(DataType.Currency)]
        [Required(ErrorMessage = "El valor a pagar es obligatorio.")]
        [Range(0.01, 1000000, ErrorMessage = "El valor a pagar debe ser mayor a 0.")]
        public decimal ValorPagar { get; set; }

        [Required(ErrorMessage = "Debe seleccionar un cliente.")]
        public int ClienteId { get; set; }

        public Cliente Cliente { get; set; }
    }
}
