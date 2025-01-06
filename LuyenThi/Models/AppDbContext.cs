using Microsoft.EntityFrameworkCore;

namespace LuyenThi.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
       public DbSet<KhachHang> KhachHangs { get; set; }
       public DbSet<DonHang> DonHangs { get; set;}
    }
}
