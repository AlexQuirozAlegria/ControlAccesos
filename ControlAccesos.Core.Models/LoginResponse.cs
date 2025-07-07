namespace ControlAccesos.Core.Models
{
    public class LoginResponse
    {
        public string token { get; set; }
        public string username { get; set; }
        public string rol { get; set; }
        public int? residenteId { get; set; }
    }
}