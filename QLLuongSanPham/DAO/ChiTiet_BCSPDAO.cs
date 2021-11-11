using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLLuongSanPham.Entities;

namespace QLLuongSanPham.DAO
{
    class ChiTiet_BCSPDAO
    {
        private QLLuongSPContext context;

        public ChiTiet_BCSPDAO()
        {
            context = new QLLuongSPContext();
        }

        public IEnumerable<CT_BangCongSP> GetChiTiets() => context.CT_BangCongSP;

        

        public bool AddCTBC(CT_BangCongSP ct)
        {
            using(var db = context.Database.BeginTransaction())
            {
                try
                {
                    context.CT_BangCongSP.Add(ct);
                    context.SaveChanges();
                    db.Commit();
                    return true;
                }
                catch (Exception)
                {
                    db.Rollback();
                    throw new Exception("Lỗi thêm chi tiết bảng công sản phẩm");
                }
               
            } 
        }


        public bool RemoveCTBC(CT_BangCongSP ct)
        {
            using (var db = context.Database.BeginTransaction())
            {
                try
                {
                    context.CT_BangCongSP.Remove(ct);
                    context.SaveChanges();
                    db.Commit();
                    return true;
                }
                catch (Exception)
                {
                    db.Rollback();
                    throw new Exception("Lỗi xóa chi tiết bảng công sản phẩm");
                }

            }
        }

        public bool UpdateCTBC(CT_BangCongSP ct)
        {
            using (var db = context.Database.BeginTransaction())
            {
                try
                {
                    context.CT_BangCongSP.Add(ct);
                    context.SaveChanges();
                    db.Commit();
                    return true;
                }
                catch (Exception)
                {
                    db.Rollback();
                    throw new Exception("Lỗi sửa chi tiết bảng công sản phẩm");
                }

            }
        }

        public IEnumerable<CT_BangCongSP> GetByIDBangCong(int id)
        {
            return context.CT_BangCongSP.Where(x => x.ID_BCSP == id);
        }
    }
}
