using DA_Xuong.Models;
using Microsoft.EntityFrameworkCore;

namespace DA_Xuong.Database
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }
        public DbSet<SACH> SACH { get; set; }
        public DbSet<LOAISACH> LOAISACH { get; set;}
        public DbSet<TACGIA> TACGIA { get; set;}
        public DbSet<CHITIETTHELOAI> CHITIETTHELOAI { get; set; }
        public DbSet<CHITIETHINHANH> CHITIETHINHANH { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TACGIA>()
                .HasMany(e => e.SACH)
                .WithOne(e => e.TACGIA)
                .HasForeignKey(e => e.IDTACGIA)
                .HasPrincipalKey(e => e.IDTACGIA);

        }
    }
}
