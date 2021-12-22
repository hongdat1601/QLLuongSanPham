namespace QLLuongSanPham.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("BangCongSP")]
    public partial class BangCongSP
    {
        public int ID { get; set; }

        public int? IDCongDoan { get; set; }

        public int? IDCaLam { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayDiLam { get; set; }

        public int? ID_NhanVien { get; set; }

        public int? SoLuongSP { get; set; }

        public bool? TrangThai { get; set; }

        public virtual CaLam CaLam { get; set; }

        public virtual CongDoan CongDoan { get; set; }

        public virtual NhanVien NhanVien { get; set; }
    }
}
