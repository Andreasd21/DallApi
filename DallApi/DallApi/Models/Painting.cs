namespace DallApi.Models
{
    public class Painting
    {
        public int Id { get; set; }
        public string Location { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public DateTime DateOfCreation { get; set; } = DateTime.Now;
        public string Creator { get; set; } = string.Empty;
        public string Prompt { get; set; } = string.Empty;
        public int Price { get; set; } = 0;
        public string Description { get; set; } = string.Empty;

    }
}
