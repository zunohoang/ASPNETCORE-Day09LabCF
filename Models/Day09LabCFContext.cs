using Microsoft.EntityFrameworkCore;

namespace Day09LabCF.Models
{
    public class Day09LabCFContext : DbContext
    {
        public Day09LabCFContext(
                DbContextOptions<Day09LabCFContext> options):base(options) { }
        
        public DbSet<Loai_San_Pham> Loai_San_Phams { get; set; }
        public DbSet<San_Pham>  San_Phams { get; set; } 
    }
}
