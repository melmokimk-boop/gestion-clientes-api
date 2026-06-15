using System;

namespace GestionClientesAPI.Models
{
    public class Mensaje
    {
        public int Id { get; set; }
        public string Contenido { get; set; } = string.Empty;
        public DateTime FechaEnvio { get; set; } = DateTime.Now;

        public int ClienteId { get; set; }
        public Cliente? Cliente { get; set; }
    }
}