namespace DallApi.Models
{
    public class Painting
    {
        public int Id { get; set; }
        public string Location { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string DateOfCreation { get; set; } = string.Empty;
        public string Creator { get; set; } = string.Empty;
        public string Prompt { get; set; } = string.Empty;

    }
}
