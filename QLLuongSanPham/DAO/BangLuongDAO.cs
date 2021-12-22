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

        public IEnumerable<BangLuong> GetBangLuongsByIDNV(int idNV)
        {
            return context.BangLuong
                .Where(x => x.IDNhanVien == idNV);
        }

        public bool Add(BangLuong bl)
        {
            using (var db = context.Database.BeginTransaction())
            {
                try
                {
                    context.BangLuong.Add(bl);
                    context.SaveChanges();
                    db.Commit();
                    return true;
                }
                catch (Exception)
                {
                    db.Rollback();
                    throw new Exception("Lỗi thêm bảng công cho công nhân");
                }

            }
        }

        public BangLuong CheckExist(int idNhanVien, int month, int year)
        {
            var bl  = GetBangLuongsByIDNV(idNhanVien)
                .Where(x => x.NgayLap.Value.Month == month 
                && x.NgayLap.Value.Year == year)
                .FirstOrDefault();

            return bl;
        }
    }
}
