using System;
using System.Collections.Generic;
using System.Linq;
using QLLuongSanPham.Entities;

namespace QLLuongSanPham.DAO
{
    class BangCongHCDAO
    {
        private QLLuongSPContext context;

        public BangCongHCDAO()
        {
            context = new QLLuongSPContext();
        }

        public IEnumerable<BangCongHC> GetBangCongHCs() => context.BangCongHC;

        public BangCongHC GetByID(int id)
        {
            return context.BangCongHC.Where(x => x.ID == id).FirstOrDefault();
        }

        public IEnumerable<BangCongHC> GetBangCongHCsByIDNhanVien(int idNhanVien)
        {
            var data = GetBangCongHCs().Where(x => x.IDNhanVien == idNhanVien);
            return data;
        }

        public IEnumerable<BangCongHC> GetBangCongHCsByIDNVAndDate(int id, int month, int year)
        {
            return context.BangCongHC
                .Where(x => x.IDNhanVien == id
                && x.NgayCham.Value.Month == month
                && x.NgayCham.Value.Year == year);
        }

        public BangCongHC CheckExist(int idNhanVien, DateTime dateTime)
        {
            var bc = GetBangCongHCsByIDNhanVien(idNhanVien)
                .Where(x => x.NgayCham.Value.Day == dateTime.Day
                && x.NgayCham.Value.Month == dateTime.Month
                && x.NgayCham.Value.Year == dateTime.Year).FirstOrDefault();

            return bc;
        }

        public bool Add(BangCongHC bc)
        {
            using (var tran = context.Database.BeginTransaction())
            {
                try
                {
                    context.BangCongHC.Add(bc);
                    context.SaveChanges();
                    tran.Commit();
                }
                catch (Exception)
                {
                    tran.Rollback();
                    return false;
                }

                return true;
            }
        }

        public bool Remove(BangCongHC bc)
        {
            using (var tran = context.Database.BeginTransaction())
            {
                try
                {
                    context.BangCongHC.Remove(bc);
                    context.SaveChanges();
                    tran.Commit();
                }
                catch (Exception)
                {
                    tran.Rollback();
                    return false;
                }

                return true;
            }
        }

        public bool Update(BangCongHC bcNew)
        {
            var bc = GetByID(bcNew.ID);

            if (bc == null)
                return false;

            bc.NgayCham = bcNew.NgayCham;
            bc.IDLoaiPhep = bcNew.IDLoaiPhep;
            context.SaveChanges();
            return true;
        }
    }
}
