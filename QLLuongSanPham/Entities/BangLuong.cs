namespace QLLuongSanPham.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("BangLuong")]
    public partial class BangLuong
    {
        public int ID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayLap { get; set; }

        public decimal TienLuong { get; set; }

        public int IDNhanVien { get; set; }

        public virtual NhanVien NhanVien { get; set; }
    }
}
