namespace QLLuongSanPham.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TaiKhoan")]
    public partial class TaiKhoan
    {
        [Key]
        [StringLength(120)]
        public string Username { get; set; }

        [StringLength(50)]
        public string Password { get; set; }

        public int? IDNhanVien { get; set; }

        public virtual NhanVien NhanVien { get; set; }
    }
}
