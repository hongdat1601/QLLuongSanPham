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

        public IEnumerable<BangLuong> GetBangLuongs() => context.BangLuongs;

        public BangLuong GetByID(int id)
        {
            return context.BangLuongs
                .Where(x => x.ID == id)
                .FirstOrDefault();
        }

        public BangLuong GetByIDNV(int idNV)
        {
            return context.BangLuongs
                .Where(x => x.IDNhanVien == idNV)
                .FirstOrDefault();
        }

        public bool Add(BangLuong bl)
        {
            using (var db = context.Database.BeginTransaction())
            {
                try
                {
                    context.BangLuongs.Add(bl);
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
    }
}
