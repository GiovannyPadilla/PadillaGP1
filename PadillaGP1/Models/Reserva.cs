namespace PadillaGP1.Models
{
    public class Reserva
    {   
       
        public DateTime FechaEntrada{ get; set; }
        public DateTime FechaSalida { get; set; }
        public int ClienteId { get; set; }
        public float valor { get; set; }
        

    }
}
