namespace DallApi.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; } =string.Empty;
        public bool PendingRequest { get; set; } = false;
        public string Email { get; set; } =string.Empty;
    }
}
