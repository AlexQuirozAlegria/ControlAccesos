using System;
using System.Text.Json.Serialization;

namespace ControlAccesos.Core.Models
{
    public class HistorialResponse
    {
        [JsonPropertyName("fechaHora")]
        public DateTime FechaHora { get; set; }

        [JsonPropertyName("tipoAcceso")]
        public string TipoAcceso { get; set; }

        [JsonPropertyName("nombrePersona")]
        public string NombrePersona { get; set; }

        [JsonPropertyName("rol")]
        public string Rol { get; set; }

        [JsonPropertyName("invitadoPor")]
        public string? InvitadoPor { get; set; }

        [JsonPropertyName("guardia")]
        public string Guardia { get; set; }

        [JsonPropertyName("placas")]
        public string? Placas { get; set; }
    }
}