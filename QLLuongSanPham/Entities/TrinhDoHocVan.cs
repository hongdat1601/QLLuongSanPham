namespace QLLuongSanPham.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TrinhDoHocVan")]
    public partial class TrinhDoHocVan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TrinhDoHocVan()
        {
            NhanViens = new HashSet<NhanVien>();
        }

        public int ID { get; set; }

        [StringLength(120)]
        public string TenTrinhDo { get; set; }

        public double? ChiSoLuongCongThem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NhanVien> NhanViens { get; set; }
    }
}
