using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLLuongSanPham.Entities;

namespace QLLuongSanPham.DAO
{
    class TaiKhoanDAO
    {
        private QLLuongSPContext context;

        public TaiKhoanDAO()
        {
            context = new QLLuongSPContext();
        }

        public IEnumerable<TaiKhoan> GetTaiKhoans() => context.TaiKhoan;

        public TaiKhoan GetTaiKhoanByID(string user)
        {
            return context.TaiKhoan
                .Where(x => x.Username == user)
                .FirstOrDefault();
        }
    }
}
