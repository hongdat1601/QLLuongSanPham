namespace QLLuongSanPham.Entities
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("SanPham")]
    public partial class SanPham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SanPham()
        {
            CongDoan = new HashSet<CongDoan>();
            ChiTietHopDong = new HashSet<ChiTietHopDong>();
        }

        public int ID { get; set; }

        [StringLength(120)]
        public string TenSP { get; set; }

        [StringLength(20)]
        public string DonViTinh { get; set; }

        public decimal? DonGia { get; set; }

        [StringLength(120)]
        public string AnhSP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CongDoan> CongDoan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietHopDong> ChiTietHopDong { get; set; }
    }
}
