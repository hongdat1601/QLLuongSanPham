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
        public int ID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayCham { get; set; }

        public int? IDNhanVien { get; set; }

        public int? IDLoaiPhep { get; set; }

        public virtual LoaiPhep LoaiPhep { get; set; }

        public virtual NhanVien NhanVien { get; set; }
    }
}
