using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ControlAccesos.Core.Models
{
    public class RegistrosAcceso
    {
        [JsonPropertyName("Id")]
        public int Id { get; set; }
    
        [JsonPropertyName("TipoAcceso")]
        public EAccessType AccessType { get; set; }
        
        [JsonPropertyName("ResidenteId")]
        public int ResidentId { get; set; }
        
        [JsonPropertyName("InvitadoId")]
        public int GuestId { get; set; }
        
        [JsonPropertyName("GuardiaId")]
        public int GuardId { get; set; }

        [JsonPropertyName("PlacasVehiculo")]
        public string Plate { get; set; }

        [JsonPropertyName("Notas")]
        public string Notes { get; set; }
    }
}
