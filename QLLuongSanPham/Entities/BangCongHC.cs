namespace QLLuongSanPham.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BangCongHC")]
    public partial class BangCongHC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BangCongHC()
        {
            LoaiPhep = new HashSet<LoaiPhep>();
        }

        public int ID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayCham { get; set; }

        public int? IDNhanVien { get; set; }

        public virtual NhanVien NhanVien { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoaiPhep> LoaiPhep { get; set; }
    }
}
