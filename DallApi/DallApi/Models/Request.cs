namespace DallApi.Models
{
    public class Request
    {
        public int Id { get; set; }
        public int DallUserId { get; set; }
        public User? User { get; set; } = new User();
        public DateTime DateOfRequest { get; set; } = DateTime.Now;
        public string Status { get; set; }= string.Empty;
        public string Prompt { get; set; } = string.Empty;


    }
}
