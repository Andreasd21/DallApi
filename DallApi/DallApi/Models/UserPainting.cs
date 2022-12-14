namespace DallApi.Models
{
    public class UserPainting
    {
        public int Id { get; set; } 
        public int PaintingId { get; set; }
        public int UserId { get; set; }
        public Painting? Painting { get; set; }
        public User? User { get; set; }
        public bool Bought { get; set; } = false;
        public DateTime DateTime { get; set; } = DateTime.Now;
    }
}
