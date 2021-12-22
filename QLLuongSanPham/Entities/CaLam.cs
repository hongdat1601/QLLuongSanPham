namespace QLLuongSanPham.Entities
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("CaLam")]
    public partial class CaLam
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CaLam()
        {
            BangCongSP = new HashSet<BangCongSP>();
        }

        public int ID { get; set; }

        [StringLength(120)]
        public string TenCa { get; set; }

        [StringLength(150)]
        public string ThoiGianLam { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BangCongSP> BangCongSP { get; set; }
    }
}
