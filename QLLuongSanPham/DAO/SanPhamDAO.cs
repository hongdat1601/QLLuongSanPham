using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLLuongSanPham.Entities;

namespace QLLuongSanPham.DAO
{
    class SanPhamDAO
    {
        private QLLuongSPContext context;

        public SanPhamDAO()
        {
            context = new QLLuongSPContext();
        }

        public IEnumerable<SanPham> GetSanPhams() => context.SanPham;


        public bool AddProcduct(SanPham sp)
        {
            using (var db = context.Database.BeginTransaction())
            {
                try
                {
                    context.SanPham.Add(sp);
                    context.SaveChanges();
                    db.Commit();
                    return true;
                }
                catch (Exception)
                {
                    db.Rollback();
                    throw new Exception("Lỗi thêm sản phẩm");
                }
            }
        }

        public bool RemoveProcduct(SanPham sp)
        {
            using (var db = context.Database.BeginTransaction())
            {
                try
                {
                    context.SanPham.Remove(sp);
                    context.SaveChanges();
                    db.Commit();
                    return true;
                }
                catch (Exception)
                {
                    db.Rollback();
                    throw new Exception("Lỗi xóa sản phẩm");
                }
            }
        }

        public bool UpdateEmployee(SanPham sp)
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
                    throw new Exception("Lỗi sửa nhân viên");
                }
            }
        }
    }
}
