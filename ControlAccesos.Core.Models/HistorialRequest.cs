using System;

namespace ControlAccesos.Core.Models
{
    public class HistorialRequest
    {
        public DateTime? fechaInicio { get; set; }
        public DateTime? fechaFin { get; set; }
        public int? residenteId { get; set; }
        public int? invitadoId { get; set; }
        public string? tipoAcceso { get; set; }
        public int? guardiaId { get; set; }
        public string? placasVehiculo { get; set; }
    }
}