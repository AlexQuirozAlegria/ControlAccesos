using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace ControlAccesos.Core.Models
{
    public class ResidentesByUsernameResponse
    {
        [JsonPropertyName("residenteId")]
        public int Id { get; set; }

        [JsonPropertyName("username")]
        public string username { get; set; }
    }
}
