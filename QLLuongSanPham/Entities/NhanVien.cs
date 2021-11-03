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
            BangCongHC = new HashSet<BangCongHC>();
            BangLuong = new HashSet<BangLuong>();
            CT_BangCongSP = new HashSet<CT_BangCongSP>();
            TaiKhoan = new HashSet<TaiKhoan>();
        }

        public int ID { get; set; }

        [StringLength(120)]
        public string HoTen { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgaySinh { get; set; }

        [StringLength(120)]
        public string DiaChi { get; set; }

        [StringLength(11)]
        public string SDT { get; set; }

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
        public virtual ICollection<BangCongHC> BangCongHC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BangLuong> BangLuong { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_BangCongSP> CT_BangCongSP { get; set; }

        public virtual ChucVu ChucVu { get; set; }

        public virtual PhongBan PhongBan { get; set; }

        public virtual TrinhDoHocVan TrinhDoHocVan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TaiKhoan> TaiKhoan { get; set; }
    }
}