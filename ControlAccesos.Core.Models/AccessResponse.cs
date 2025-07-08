using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ControlAccesos.Core.Models
{
    public class AccessResponse
    {
        [JsonPropertyName("Id")]
        public int Id { get; set; }

        [JsonPropertyName("FechaHora")]
        public DateTime datetime { get; set; }

        [JsonPropertyName("TipoAcceso")]
        public EState state { get; set; }

        [JsonPropertyName("NombreResidente")]
        public string? NombreResidente { get; set; }

        [JsonPropertyName("ApellidosResidente")]
        public string? ApellidosResidente { get; set; }

        [JsonPropertyName("DomicilioResidente")]
        public string? DomicilioResidente { get; set; }

        [JsonPropertyName("NombreInvitado")]
        public string? NombreInvitado { get; set; }

        [JsonPropertyName("ApellidosInvitado")]
        public string? ApellidosInvitado { get; set; }

        [JsonPropertyName("TipoInvitacionInvitado")]
        public string? TipoInvitacionInvitado { get; set; }

        [JsonPropertyName("NombreGuardia")]
        public string? NombreGuardia { get; set; }

        [JsonPropertyName("ApellidosGuardia")]
        public string? ApellidosGuardia { get; set; }

        [JsonPropertyName("PlacasVehiculo")]
        public string? PlacasVehiculo { get; set; }

        [JsonPropertyName("Notas")]
        public string? Notas { get; set; }
    }
}
