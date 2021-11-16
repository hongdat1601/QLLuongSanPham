namespace QLLuongSanPham.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CongDoan")]
    public partial class CongDoan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CongDoan()
        {
            BangCongSPs = new HashSet<BangCongSP>();
        }

        public int ID { get; set; }

        [StringLength(120)]
        public string TenCongDoan { get; set; }

        public decimal? DonGia { get; set; }

        public int? IDSanPham { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BangCongSP> BangCongSPs { get; set; }

        public virtual SanPham SanPham { get; set; }
    }
}
