using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace QuanLyBanHang.DAL.Models
{
    public partial class QuanLyBanHangContext : DbContext
    {
        public QuanLyBanHangContext()
        {
        }

        public QuanLyBanHangContext(DbContextOptions<QuanLyBanHangContext> options)
            : base(options)
        {
        }

        public virtual DbSet<HoaDon> HoaDons { get; set; } = null!;
        public virtual DbSet<HoaDonChiTiet> HoaDonChiTiets { get; set; } = null!;
        public virtual DbSet<KhachHang> KhachHangs { get; set; } = null!;
        public virtual DbSet<KhuyenMai> KhuyenMais { get; set; } = null!;
        public virtual DbSet<NhanVien> NhanViens { get; set; } = null!;
        public virtual DbSet<SanPham> SanPhams { get; set; } = null!;
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; } = null!;
        public virtual DbSet<ThanhToan> ThanhToans { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=TSƠN\\NGUYENSONDEV;Database=QuanLyBanHang;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HoaDon>(entity =>
            {
                entity.HasKey(e => e.Idhd);

                entity.ToTable("HoaDon");

                entity.Property(e => e.Idhd).HasColumnName("IDHD");

                entity.Property(e => e.Idkh).HasColumnName("IDKH");

                entity.Property(e => e.Idkm).HasColumnName("IDKM");

                entity.Property(e => e.Idnv).HasColumnName("IDNV");

                entity.Property(e => e.IdthanhToan).HasColumnName("IDThanhToan");

                entity.Property(e => e.NgayTao)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.IdkhNavigation)
                    .WithMany(p => p.HoaDons)
                    .HasForeignKey(d => d.Idkh)
                    .HasConstraintName("FK_HoaDon_KhachHang");

                entity.HasOne(d => d.IdkmNavigation)
                    .WithMany(p => p.HoaDons)
                    .HasForeignKey(d => d.Idkm)
                    .HasConstraintName("FK_HoaDon_KhuyenMai");

                entity.HasOne(d => d.IdnvNavigation)
                    .WithMany(p => p.HoaDons)
                    .HasForeignKey(d => d.Idnv)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HoaDon_NhanVien");

                entity.HasOne(d => d.IdthanhToanNavigation)
                    .WithMany(p => p.HoaDons)
                    .HasForeignKey(d => d.IdthanhToan)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HoaDon_ThanhToan");
            });

            modelBuilder.Entity<HoaDonChiTiet>(entity =>
            {
                entity.ToTable("HoaDonChiTiet");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Idhd).HasColumnName("IDHD");

                entity.Property(e => e.Idsp).HasColumnName("IDSp");

                entity.Property(e => e.TenSp).HasMaxLength(50);

                entity.HasOne(d => d.IdhdNavigation)
                    .WithMany(p => p.HoaDonChiTiets)
                    .HasForeignKey(d => d.Idhd)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HoaDonChiTiet_HoaDon");

                entity.HasOne(d => d.IdspNavigation)
                    .WithMany(p => p.HoaDonChiTiets)
                    .HasForeignKey(d => d.Idsp)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HoaDonChiTiet_SanPham");
            });

            modelBuilder.Entity<KhachHang>(entity =>
            {
                entity.HasKey(e => e.Idkh);

                entity.ToTable("KhachHang");

                entity.Property(e => e.Idkh).HasColumnName("IDKH");

                entity.Property(e => e.Sdt)
                    .HasMaxLength(10)
                    .HasColumnName("SDT");

                entity.Property(e => e.TenKh)
                    .HasMaxLength(50)
                    .HasColumnName("TenKH");
            });

            modelBuilder.Entity<KhuyenMai>(entity =>
            {
                entity.HasKey(e => e.IdkhuyenMai);

                entity.ToTable("KhuyenMai");

                entity.Property(e => e.IdkhuyenMai).HasColumnName("IDKhuyenMai");

                entity.Property(e => e.NgayBatDau)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NgayKetThuc).HasColumnType("date");
            });

            modelBuilder.Entity<NhanVien>(entity =>
            {
                entity.HasKey(e => e.Idnv);

                entity.ToTable("NhanVien");

                entity.Property(e => e.Idnv).HasColumnName("IDNV");

                entity.Property(e => e.ChucVu).HasMaxLength(50);

                entity.Property(e => e.Idtk).HasColumnName("IDTK");

                entity.Property(e => e.Mail).HasMaxLength(50);

                entity.Property(e => e.Sdt)
                    .HasMaxLength(10)
                    .HasColumnName("SDT");

                entity.Property(e => e.TenNv)
                    .HasMaxLength(50)
                    .HasColumnName("TenNV");

                entity.HasOne(d => d.IdtkNavigation)
                    .WithMany(p => p.NhanViens)
                    .HasForeignKey(d => d.Idtk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NhanVien_TaiKhoan");
            });

            modelBuilder.Entity<SanPham>(entity =>
            {
                entity.HasKey(e => e.Idsp);

                entity.ToTable("SanPham");

                entity.Property(e => e.Idsp).HasColumnName("IDSP");

                entity.Property(e => e.HinhAnh)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LoaiSp).HasMaxLength(50);

                entity.Property(e => e.MoTa).HasMaxLength(50);

                entity.Property(e => e.NgayNhap)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Sl).HasColumnName("SL");

                entity.Property(e => e.SldaBan).HasColumnName("SLDaBan");

                entity.Property(e => e.TenSp).HasMaxLength(50);

                entity.Property(e => e.ThuongHieu).HasMaxLength(50);
            });

            modelBuilder.Entity<TaiKhoan>(entity =>
            {
                entity.HasKey(e => e.Idtk);

                entity.ToTable("TaiKhoan");

                entity.Property(e => e.Idtk).HasColumnName("IDTK");

                entity.Property(e => e.MatKhau).HasMaxLength(50);

                entity.Property(e => e.TenTk).HasMaxLength(50);
            });

            modelBuilder.Entity<ThanhToan>(entity =>
            {
                entity.HasKey(e => e.IdThanhToan);

                entity.ToTable("ThanhToan");

                entity.Property(e => e.HinhThuc).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
