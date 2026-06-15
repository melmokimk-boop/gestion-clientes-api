using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace GestionClientesAPI.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        [JsonIgnore] 
        public List<Mensaje> Mensajes { get; set; } = new();
    }
}