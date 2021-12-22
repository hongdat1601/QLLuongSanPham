namespace QLLuongSanPham.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("ChiTietHopDong")]
    public partial class ChiTietHopDong
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDSanPham { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDHopDong { get; set; }

        public int? SoLuong { get; set; }

        public virtual HopDong HopDong { get; set; }

        public virtual SanPham SanPham { get; set; }
    }
}
