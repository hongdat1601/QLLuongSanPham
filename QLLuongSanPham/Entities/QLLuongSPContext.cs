using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QLLuongSanPham.Entities
{
    public partial class QLLuongSPContext : DbContext
    {
        public QLLuongSPContext()
            : base("name=QLLuongSPContext")
        {
        }

        public virtual DbSet<BangCongHC> BangCongHCs { get; set; }
        public virtual DbSet<BangCongSP> BangCongSPs { get; set; }
        public virtual DbSet<BangLuong> BangLuongs { get; set; }
        public virtual DbSet<CaLam> CaLams { get; set; }
        public virtual DbSet<ChiTietHopDong> ChiTietHopDongs { get; set; }
        public virtual DbSet<ChucVu> ChucVus { get; set; }
        public virtual DbSet<CongDoan> CongDoans { get; set; }
        public virtual DbSet<HopDong> HopDongs { get; set; }
        public virtual DbSet<LoaiPhep> LoaiPheps { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<PhongBan> PhongBans { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }
        public virtual DbSet<TrinhDoHocVan> TrinhDoHocVans { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BangLuong>()
                .Property(e => e.TienLuong)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CaLam>()
                .HasMany(e => e.BangCongSPs)
                .WithOptional(e => e.CaLam)
                .HasForeignKey(e => e.IDCaLam);

            modelBuilder.Entity<ChucVu>()
                .Property(e => e.PhuCap)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ChucVu>()
                .HasMany(e => e.NhanViens)
                .WithOptional(e => e.ChucVu)
                .HasForeignKey(e => e.IDChucVu);

            modelBuilder.Entity<CongDoan>()
                .Property(e => e.DonGia)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CongDoan>()
                .HasMany(e => e.BangCongSPs)
                .WithOptional(e => e.CongDoan)
                .HasForeignKey(e => e.IDCongDoan);

            modelBuilder.Entity<HopDong>()
                .HasMany(e => e.ChiTietHopDongs)
                .WithRequired(e => e.HopDong)
                .HasForeignKey(e => e.IDHopDong);

            modelBuilder.Entity<LoaiPhep>()
                .Property(e => e.PhuCap)
                .HasPrecision(18, 0);

            modelBuilder.Entity<LoaiPhep>()
                .HasMany(e => e.BangCongHCs)
                .WithOptional(e => e.LoaiPhep)
                .HasForeignKey(e => e.IDLoaiPhep);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.CMND)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.LuongCanBan)
                .HasPrecision(18, 0);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.Anh)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.BangCongHCs)
                .WithOptional(e => e.NhanVien)
                .HasForeignKey(e => e.IDNhanVien)
                .WillCascadeOnDelete();

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.BangCongSPs)
                .WithOptional(e => e.NhanVien)
                .HasForeignKey(e => e.ID_NhanVien)
                .WillCascadeOnDelete();

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.BangLuongs)
                .WithRequired(e => e.NhanVien)
                .HasForeignKey(e => e.IDNhanVien);

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.TaiKhoans)
                .WithOptional(e => e.NhanVien)
                .HasForeignKey(e => e.IDNhanVien)
                .WillCascadeOnDelete();

            modelBuilder.Entity<PhongBan>()
                .HasMany(e => e.NhanViens)
                .WithOptional(e => e.PhongBan)
                .HasForeignKey(e => e.IDPhongBan);

            modelBuilder.Entity<SanPham>()
                .Property(e => e.DonGia)
                .HasPrecision(18, 0);

            modelBuilder.Entity<SanPham>()
                .Property(e => e.AnhSP)
                .IsUnicode(false);

            modelBuilder.Entity<SanPham>()
                .HasMany(e => e.ChiTietHopDongs)
                .WithRequired(e => e.SanPham)
                .HasForeignKey(e => e.IDSanPham);

            modelBuilder.Entity<SanPham>()
                .HasMany(e => e.CongDoans)
                .WithOptional(e => e.SanPham)
                .HasForeignKey(e => e.IDSanPham)
                .WillCascadeOnDelete();

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<TrinhDoHocVan>()
                .HasMany(e => e.NhanViens)
                .WithOptional(e => e.TrinhDoHocVan)
                .HasForeignKey(e => e.IDTrinhDoHocVan);
        }
    }
}
