using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using QLLuongSanPham.Entities;

namespace QLLuongSanPham.DAO
{
    class HopDongDAO
    {
        QLLuongSPContext context;

        public HopDongDAO()
        {
            context = new QLLuongSPContext();
        }

        public IEnumerable<HopDong> GetHopDongs() => context.HopDong;

        public IEnumerable<HopDong> GetHopDongByChar(string input)
        {
            return context.HopDong.Where(x => x.TenHopDong.Contains(input));
        }

        public HopDong GetById(int id)
        {
            return context.HopDong
                .Where(x => x.ID == id)
                .FirstOrDefault();
        }

        public void UpdateTrangThai()
        {
            var list = context.HopDong;

            foreach (var item in list)
            {
                if (DateTime.Now.CompareTo(item.NgayKetThuc.Value) > 0 && item.TrangThai.Value)
                {
                    item.TrangThai = false;
                }
            }     
            context.SaveChanges();
        }
    }
}
