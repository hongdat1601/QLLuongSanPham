using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using QLLuongSanPham.DAL;

namespace QLLuongSanPham.BLL
{
    class NhanVienBLL : ConnectionBLL
    {
        public NhanVienBLL()
        {

        }

        public IEnumerable<NhanVien> GetNhanViens() => context.NhanViens;

        public NhanVien GetById(int id)
        {
            return context.NhanViens
                .Where(x => x.ID == id)
                .FirstOrDefault();
        }
    }
}
