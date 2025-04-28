using System.ComponentModel.DataAnnotations;

namespace PadillaGP1.Models
{
    public class PlanDeRecompensas
    {
        [Key]
        public string id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        [StringLength(50, ErrorMessage = "Máximo 50 caracteres.")]
        public string nombre { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Debe ingresar la fecha de inicio.")]
        public DateTime fechaInicio { get; set; }

        [Range(0, float.MaxValue, ErrorMessage = "Los puntos deben ser positivos.")]
        public float puntosAcumulados { get; set; }

        public string tipoRecompensa
        {
            get
            {
                return puntosAcumulados >= 500 ? "GOLD" : "SILVER";
            }

        }
    }
}
