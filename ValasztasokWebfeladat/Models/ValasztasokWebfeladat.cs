using Microsoft.EntityFrameworkCore;

namespace ValasztasokWebfeladat.Models
{
    public class ValasztasokWebfeladat :DbContext
    {
        public ValasztasokWebfeladat (DbContextOptions<ValasztasokWebfeladat> options): base(options) { }

        public DbSet<Jelolt> Jeloltek { get; set; }
        public DbSet<Part> Parts { get; set; }
    }
}
