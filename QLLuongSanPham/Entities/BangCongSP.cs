namespace QLLuongSanPham.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BangCongSP")]
    public partial class BangCongSP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BangCongSP()
        {
            CT_BangCongSP = new HashSet<CT_BangCongSP>();
        }

        public int ID { get; set; }

        public int? IDCongDoan { get; set; }

        public int? IDCaLam { get; set; }

        public int? SoLuongNguoi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_BangCongSP> CT_BangCongSP { get; set; }

        public virtual CaLam CaLam { get; set; }

        public virtual CongDoan CongDoan { get; set; }
    }
}
