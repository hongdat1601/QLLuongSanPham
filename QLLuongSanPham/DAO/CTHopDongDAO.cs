using System;
using System.Collections.Generic;
using System.Linq;
using QLLuongSanPham.Entities;

namespace QLLuongSanPham.DAO
{
    class CTHopDongDAO
    {
        private QLLuongSPContext context;

        public CTHopDongDAO()
        {
            context = new QLLuongSPContext();
        }

        public IEnumerable<ChiTietHopDong> GetCTHDsByIdHopDong(int id)
        {
            return context.ChiTietHopDong.Where(x => x.IDHopDong == id);
        }

        public bool Add(ChiTietHopDong cthd)
        {
            using (var tran = context.Database.BeginTransaction())
            {
                try
                {
                    context.ChiTietHopDong.Add(cthd);
                    context.SaveChanges();
                    tran.Commit();
                }
                catch (Exception)
                {
                    tran.Rollback();
                    return false;
                }
            }

            return true;
        }
    }
}
