using DallApi.Models;
using Microsoft.EntityFrameworkCore;

namespace DallApi.Data
{
    public class DataContext :DbContext
    {
        public DataContext()
        {
        }
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Painting> Paintings { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<User> DallUsers { get; set; }
        public DbSet<UserPainting> UserPaintings { get; set; }
    }
}
