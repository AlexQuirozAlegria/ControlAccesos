using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace ControlAccesos.Core.Models
{
    public class User
    {
        [JsonPropertyName("username")]
        public string Username { get; set; }

        [JsonPropertyName("password")]
        public string Password { get; set; }

        [JsonPropertyName("rol")]
        public ERole Role { get; set; }

        [JsonPropertyName("nombre")]
        public string Name { get; set; }

        [JsonPropertyName("apellidos")]
        public string LastName { get; set; }

        [JsonPropertyName("placas")]
        public string Plate { get; set; }

        [JsonPropertyName("domicilio")]
        public string Address { get; set; }

        [JsonPropertyName("telefono")]
        public string Phone { get; set; }

        [JsonPropertyName("Vehiculo")]
        public string Model  { get; set; }
    }
}
