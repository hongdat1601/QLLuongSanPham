namespace QLLuongSanPham.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SanPham")]
    public partial class SanPham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SanPham()
        {
            ChiTietHopDongs = new HashSet<ChiTietHopDong>();
            CongDoans = new HashSet<CongDoan>();
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
        public virtual ICollection<ChiTietHopDong> ChiTietHopDongs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CongDoan> CongDoans { get; set; }
    }
}
