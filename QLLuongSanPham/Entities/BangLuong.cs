namespace QLLuongSanPham.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BangLuong")]
    public partial class BangLuong
    {
        public int ID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayLap { get; set; }

        [Column(TypeName = "money")]
        public decimal? TienLuong { get; set; }

        public int? IDNhanVien { get; set; }

        public int? SoBuoiLamThem { get; set; }

        public virtual NhanVien NhanVien { get; set; }
    }
}
