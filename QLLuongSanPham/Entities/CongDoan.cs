namespace QLLuongSanPham.Entities
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("CongDoan")]
    public partial class CongDoan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CongDoan()
        {
            BangCongSP = new HashSet<BangCongSP>();
        }

        public int ID { get; set; }

        [StringLength(120)]
        public string TenCongDoan { get; set; }

        public decimal? DonGia { get; set; }

        public int? IDSanPham { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BangCongSP> BangCongSP { get; set; }

        public virtual SanPham SanPham { get; set; }
    }
}
