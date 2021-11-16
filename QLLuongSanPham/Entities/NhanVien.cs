namespace QLLuongSanPham.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhanVien")]
    public partial class NhanVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NhanVien()
        {
            BangCongHCs = new HashSet<BangCongHC>();
            BangCongSPs = new HashSet<BangCongSP>();
            BangLuongs = new HashSet<BangLuong>();
            TaiKhoans = new HashSet<TaiKhoan>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(120)]
        public string HoTen { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgaySinh { get; set; }

        [Required]
        [StringLength(120)]
        public string DiaChi { get; set; }

        [Required]
        [StringLength(11)]
        public string SDT { get; set; }

        [Required]
        [StringLength(12)]
        public string CMND { get; set; }

        public int? IDPhongBan { get; set; }

        public double? ChiSoLuong { get; set; }

        public decimal? LuongCanBan { get; set; }

        public double? TrinhDoNgoaiNgu { get; set; }

        public int? ThamNienCongTac { get; set; }

        public int? IDChucVu { get; set; }

        public int? IDTrinhDoHocVan { get; set; }

        [StringLength(120)]
        public string Anh { get; set; }

        public bool? GioiTinh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BangCongHC> BangCongHCs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BangCongSP> BangCongSPs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BangLuong> BangLuongs { get; set; }

        public virtual ChucVu ChucVu { get; set; }

        public virtual PhongBan PhongBan { get; set; }

        public virtual TrinhDoHocVan TrinhDoHocVan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TaiKhoan> TaiKhoans { get; set; }
    }
}
