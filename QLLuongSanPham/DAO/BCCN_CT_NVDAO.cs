using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLLuongSanPham.Entities;

namespace QLLuongSanPham.DAO
{
    class BCCN_CT_NVDAO
    {
        private QLLuongSPContext context;

        public BCCN_CT_NVDAO()
        {
            context = new QLLuongSPContext();
        }

        public IEnumerable<dynamic> GetIDAndTenNVByIDSP(int idSP)
        {
            var q = from cd in context.CongDoan
                    where cd.IDSanPham == idSP
                    join bc in context.BangCongSP
                    on cd.ID equals bc.IDCongDoan
                    join ct in context.CT_BangCongSP
                    on bc.ID equals ct.ID_BCSP
                    join nv in context.NhanVien
                    on ct.ID_NV equals nv.ID
                    select new { id = ct.ID_NV, ten = nv.HoTen, 
                        chucvu = nv.IDChucVu, idCD = cd.ID, idCa = bc.IDCaLam, ngay = bc.NgayDiLam };
            return q;
        }

        public IEnumerable<dynamic> GetNVByIdCa(int idCa)
        {
            var q = from ca in context.CaLam
                    where ca.ID == idCa
                    join bc in context.BangCongSP
                    on ca.ID equals bc.IDCaLam
                    join ct in context.CT_BangCongSP
                    on bc.ID equals ct.ID_BCSP
                    join nv in context.NhanVien
                    on ct.ID_NV equals nv.ID
                    select new
                    {
                        id = ct.ID_NV,
                        ten = nv.HoTen,
                        chucvu = nv.IDChucVu,
                        idCa = bc.IDCaLam,
                    };
            return q;
        }

        public IEnumerable<dynamic> GetIDAndTenNVByIDNV(int idNV)
        {
            var q = from nv in context.NhanVien
                    where nv.ID == idNV
                    select new { id = nv.ID, ten = nv.HoTen, chucvu = nv.IDChucVu};

            return q;
        }

        public IEnumerable<dynamic> GetAllNV()
        {
            var q = from nv in context.NhanVien
                    select new { id = nv.ID, ten = nv.HoTen, chucvu = nv.IDChucVu };
            return q;
        }

        public int GetIDCaBySp()
        {
            var q = from sp in context.SanPham
                    join cd in context.CongDoan
                    on sp.ID equals cd.IDSanPham
                    join bc in context.BangCongSP
                    on cd.ID equals bc.IDCongDoan
                    join ca in context.CaLam
                    on bc.IDCaLam equals ca.ID
                    select bc.IDCaLam;
            int id = (int)q.FirstOrDefault();
            return id;
        }

        public string GetNameChucVu(int id)
        {
            string name = null;
            name = context.ChucVu.Where(x => x.ID == id).FirstOrDefault().TenChucVu;
            return name;
        }
    }
}
