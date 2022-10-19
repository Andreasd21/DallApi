namespace DallApi.Models
{
    public class UserPainting
    {
        public int Id { get; set; } 
        public Painting Painting { get; set; } = new Painting();
        public User User { get; set; } = new User();
        public bool Bought { get; set; } = false;
        public DateTime DateTime { get; set; } = DateTime.Now;
    }
}
