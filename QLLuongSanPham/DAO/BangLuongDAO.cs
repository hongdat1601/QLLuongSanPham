using QLLuongSanPham.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLLuongSanPham.DAO
{
    class BangLuongDAO
    {
        private QLLuongSPContext context;

        public BangLuongDAO()
        {
            context = new QLLuongSPContext();
        }

        public IEnumerable<BangLuong> GetBangLuongs() => context.BangLuong;

        public BangLuong GetByID(int id)
        {
            return context.BangLuong
                .Where(x => x.ID == id)
                .FirstOrDefault();
        }

        public IEnumerable<BangLuong> GetByIDNV(int idNV)
        {
            return context.BangLuong
                .Where(x => x.IDNhanVien == idNV);
        }
    }
}
