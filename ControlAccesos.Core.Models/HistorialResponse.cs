using System;
using System.Text.Json.Serialization;

namespace ControlAccesos.Core.Models
{
    public class HistorialResponse
    {
        public int Id { get; set; }
        public DateTime FechaHora { get; set; }
        public string? TipoAcceso { get; set; }
        public string? NombreResidente { get; set; }
        public string? ApellidosResidente { get; set; }
        public string? DomicilioResidente { get; set; }
        public string? NombreInvitado { get; set; }
        public string? ApellidosInvitado { get; set; }
        public string? TipoInvitacionInvitado { get; set; }
        public string? NombreGuardia { get; set; }
        public string? ApellidosGuardia { get; set; }
        public string? PlacasVehiculo { get; set; }
        public string? Notas { get; set; }
    }
}