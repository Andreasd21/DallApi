namespace DallApi.Models
{
    public class Request
    {
        public int Id { get; set; }
        public string User { get; set; } = string.Empty;
        public string DateOfRequest { get; set; } = string.Empty;
        public string DateOfHandling { get; set; } = string.Empty;
        public string Status { get; set; }= string.Empty;


    }
}
