using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace ControlAccesos.Core.Models
{
    public class Residentes
    {
        [JsonPropertyName("Id")]
        public int Id { get; set; }

        [JsonPropertyName("Nombre")]
        public string Name { get; set; }

        [JsonPropertyName("Apellidos")]
        public string LastName { get; set; }

        [JsonPropertyName("Domicilio")]
        public string Address { get; set; }

        [JsonPropertyName("Telefono")]
        public string Phone { get; set; }

        [JsonPropertyName("Vehiculo")]
        public string Model { get; set; }

        [JsonPropertyName("Placas")]
        public string Plate { get; set; }

        [JsonPropertyName("UserId")]
        public int UserId { get; set; }
    }
}
