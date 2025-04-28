using System.ComponentModel.DataAnnotations;

namespace PadillaGP1.Models
{
    public class PlanDeRecompensas
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        [StringLength(50, ErrorMessage = "Máximo 50 caracteres.")]
        public string Nombre { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Debe ingresar la fecha de inicio.")]
        public DateTime FechaInicio { get; set; }

        [Range(0, float.MaxValue, ErrorMessage = "Los puntos deben ser positivos.")]
        public float PuntosAcumulados { get; set; }

        public string TipoRecompensa
        {
            get
            {
                return PuntosAcumulados >= 500 ? "GOLD" : "SILVER";
            }

        }
    }
}
