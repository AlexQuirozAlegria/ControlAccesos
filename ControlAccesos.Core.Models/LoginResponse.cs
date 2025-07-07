namespace ControlAccesos.Core.Models
{
    public class LoginResponse
    {
        public string Token { get; set; }
        public string Username { get; set; }
        public string Rol { get; set; }
        public int? ResidenteId { get; set; }
    }
}