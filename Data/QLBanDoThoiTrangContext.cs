using CommentFunction.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace CommentFunction.Data
{
    public class QLBanDoThoiTrangContext : DbContext
    {
        public QLBanDoThoiTrangContext(DbContextOptions<QLBanDoThoiTrangContext> options) : base(options) { }
        public virtual DbSet<TDanhGia> TDanhGias { get; set; }
        public virtual DbSet<TPhanHoi> TPhanHois { get; set; }
        public virtual DbSet<TKhachHang> TKhachHangs { get; set; }
        public virtual DbSet<TNhanVien> TNhanViens { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TDanhGia>(entity =>
            {
                entity.HasKey(d => d.MaDanhGia);
                entity.ToTable("tReview");
            });

            modelBuilder.Entity<TPhanHoi>(entity =>
            {
                entity.HasKey(e => new { e.MaKhachHang, e.MaDanhGia });
                entity.ToTable("tReactReview");
            });

            modelBuilder.Entity<TKhachHang>(entity =>
            {
                entity.HasKey(d => d.MaKhachHang);
                entity.ToTable("tKhachHang");
            });

            modelBuilder.Entity<TNhanVien>(entity =>
            {
                entity.HasKey(d => d.MaNhanVien);
                entity.ToTable("tNhanVien");
            });

        }
    }
}
