using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ControlAccesos.Core.Models
{
    public class RegisterAccessRequest
    {
        [JsonPropertyName("invitadoQrCode")]
        public string qrcode { get; set; }

        [JsonPropertyName("residentUsername")]
        public string? residentUsername { get; set; }

        [JsonPropertyName("tipoAcceso")]
        public EState state { get; set; }

        [JsonPropertyName("placasVehiculo")]
        public string? Plate { get; set; }

        [JsonPropertyName("Notas")]
        public string? Notes { get; set; }
    }
}