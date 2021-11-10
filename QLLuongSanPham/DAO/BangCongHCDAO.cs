using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public bool AddLich(BangCongHC lich)
        {
            using (var db = context.Database.BeginTransaction())
            {
                try
                {
                    context.BangCongHC.Add(lich);
                    context.SaveChanges();
                    db.Commit();
                    return true;
                }
                catch (Exception)
                {
                    db.Rollback();
                    throw new Exception("Lỗi thêm lịch");
                }
               
            }
        }

        public bool UpdateBangCong(BangCongHC bc)
        {
            using (var db = context.Database.BeginTransaction())
            {
                try
                {
                    context.SaveChanges();
                    db.Commit();
                    return true;
                }
                catch (Exception)
                {
                    db.Rollback();
                    throw new Exception("Lỗi sữa nhân viên");
                }
            }
        }

        public bool RemoveBangCong(BangCongHC bc)
        {
            using (var db = context.Database.BeginTransaction())
            {
                try
                {
                    context.BangCongHC.Remove(bc);
                    context.SaveChanges();
                    db.Commit();
                    return true;
                }
                catch (Exception)
                {
                    db.Rollback();
                    throw new Exception("Lỗi sữa nhân viên");
                }
            }
        }
    }
}
