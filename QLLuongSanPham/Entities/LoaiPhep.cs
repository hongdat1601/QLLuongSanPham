namespace QLLuongSanPham.Entities
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("LoaiPhep")]
    public partial class LoaiPhep
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LoaiPhep()
        {
            BangCongHC = new HashSet<BangCongHC>();
        }

        public int ID { get; set; }

        [StringLength(150)]
        public string TenPhep { get; set; }

        public decimal? PhuCap { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BangCongHC> BangCongHC { get; set; }
    }
}
