using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace ControlAccesos.Core.Models
{
    public class Invitado
    {
        [JsonPropertyName("invitadoId")]
        public int Id { get; set; }

        [JsonPropertyName("nombreInvitado")]
        public string Name { get; set; }

        [JsonPropertyName("apellidosInvitado")]
        public string LastName { get; set; }

        [JsonPropertyName("tipoInvitacion")]
        public EAccessType Type { get; set; }

        [JsonPropertyName("fechaValidez")]
        public DateTime? date { get; set; }

        [JsonPropertyName("residenteQueInvita")]
        public string Host { get; set; }

        [JsonPropertyName("mensaje")]
        public string Message { get; set; }
    }
}
