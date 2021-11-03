using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using QLLuongSanPham.DAL;

namespace QLLuongSanPham.BLL
{
    class SanPhamBLL : ConnectionBLL
    {
        public SanPhamBLL()
        {

        }

        public IEnumerable<SanPham> GetSanPhams() => context.SanPhams;
    }
}
