using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using QLLuongSanPham.DAL;

namespace QLLuongSanPham.BLL
{
    class HopDongBLL : ConnectionBLL
    {
        public HopDongBLL()
        {

        }

        public IEnumerable<HopDong> GetHopDongs() => context.HopDongs;
    }
}
