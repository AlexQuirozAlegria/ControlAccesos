using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ControlAccesos.Core.Models
{
    public class loginRequest
    {
        [JsonPropertyName("Username")]
        public string Username { get; set; }
        [JsonPropertyName("Password")]
        public string Password { get; set; }
    }
}
