using System;

namespace ControlAccesos.Core.Models
{
    public class AccessHistoryRequest
    {
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public int? ResidenteId { get; set; }
        public int? InvitadoId { get; set; }
        public string? TipoAcceso { get; set; }
        public int? GuardiaId { get; set; }
        public string? PlacasVehiculo { get; set; }
        public EPersona? tipoDePersona { get; set; }
    }
}