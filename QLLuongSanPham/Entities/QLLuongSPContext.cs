using System.Data.Entity;

namespace QLLuongSanPham.Entities
{
    public partial class QLLuongSPContext : DbContext
    {
        public QLLuongSPContext()
            : base("name=QLLuongSPContext1")
        {
        }

        public virtual DbSet<BangCongHC> BangCongHC { get; set; }
        public virtual DbSet<BangCongSP> BangCongSP { get; set; }
        public virtual DbSet<BangLuong> BangLuong { get; set; }
        public virtual DbSet<CaLam> CaLam { get; set; }
        public virtual DbSet<CongDoan> CongDoan { get; set; }
        public virtual DbSet<ChiTietHopDong> ChiTietHopDong { get; set; }
        public virtual DbSet<ChucVu> ChucVu { get; set; }
        public virtual DbSet<HopDong> HopDong { get; set; }
        public virtual DbSet<LoaiPhep> LoaiPhep { get; set; }
        public virtual DbSet<NhanVien> NhanVien { get; set; }
        public virtual DbSet<PhongBan> PhongBan { get; set; }
        public virtual DbSet<SanPham> SanPham { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoan { get; set; }
        public virtual DbSet<TrinhDoHocVan> TrinhDoHocVan { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BangLuong>()
                .Property(e => e.TienLuong)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CaLam>()
                .HasMany(e => e.BangCongSP)
                .WithOptional(e => e.CaLam)
                .HasForeignKey(e => e.IDCaLam);

            modelBuilder.Entity<CongDoan>()
                .Property(e => e.DonGia)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CongDoan>()
                .HasMany(e => e.BangCongSP)
                .WithOptional(e => e.CongDoan)
                .HasForeignKey(e => e.IDCongDoan);

            modelBuilder.Entity<ChucVu>()
                .Property(e => e.PhuCap)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ChucVu>()
                .HasMany(e => e.NhanVien)
                .WithOptional(e => e.ChucVu)
                .HasForeignKey(e => e.IDChucVu);

            modelBuilder.Entity<HopDong>()
                .HasMany(e => e.ChiTietHopDong)
                .WithRequired(e => e.HopDong)
                .HasForeignKey(e => e.IDHopDong);

            modelBuilder.Entity<LoaiPhep>()
                .Property(e => e.PhuCap)
                .HasPrecision(18, 0);

            modelBuilder.Entity<LoaiPhep>()
                .HasMany(e => e.BangCongHC)
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
                .HasMany(e => e.BangCongHC)
                .WithOptional(e => e.NhanVien)
                .HasForeignKey(e => e.IDNhanVien)
                .WillCascadeOnDelete();

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.BangCongSP)
                .WithOptional(e => e.NhanVien)
                .HasForeignKey(e => e.ID_NhanVien)
                .WillCascadeOnDelete();

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.BangLuong)
                .WithRequired(e => e.NhanVien)
                .HasForeignKey(e => e.IDNhanVien);

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.TaiKhoan)
                .WithOptional(e => e.NhanVien)
                .HasForeignKey(e => e.IDNhanVien)
                .WillCascadeOnDelete();

            modelBuilder.Entity<PhongBan>()
                .HasMany(e => e.NhanVien)
                .WithOptional(e => e.PhongBan)
                .HasForeignKey(e => e.IDPhongBan);

            modelBuilder.Entity<SanPham>()
                .Property(e => e.DonGia)
                .HasPrecision(18, 0);

            modelBuilder.Entity<SanPham>()
                .Property(e => e.AnhSP)
                .IsUnicode(false);

            modelBuilder.Entity<SanPham>()
                .HasMany(e => e.CongDoan)
                .WithOptional(e => e.SanPham)
                .HasForeignKey(e => e.IDSanPham)
                .WillCascadeOnDelete();

            modelBuilder.Entity<SanPham>()
                .HasMany(e => e.ChiTietHopDong)
                .WithRequired(e => e.SanPham)
                .HasForeignKey(e => e.IDSanPham);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<TrinhDoHocVan>()
                .HasMany(e => e.NhanVien)
                .WithOptional(e => e.TrinhDoHocVan)
                .HasForeignKey(e => e.IDTrinhDoHocVan);
        }
    }
}
