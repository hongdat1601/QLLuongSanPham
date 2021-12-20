using System;
using System.Collections.Generic;
using System.Linq;
using QLLuongSanPham.Entities;

namespace QLLuongSanPham.DAO
{
    class TaiKhoanDAO
    {
        private QLLuongSPContext context;

        public TaiKhoanDAO()
        {
            context = new QLLuongSPContext();
        }

        public IEnumerable<TaiKhoan> GetTaiKhoans() => context.TaiKhoan;

        public TaiKhoan GetTaiKhoanByID(string user)
        {
            return context.TaiKhoan
                .Where(x => x.Username == user)
                .FirstOrDefault();
        }

        public bool UpdateTaiKhoan(TaiKhoan tk)
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
                    throw new Exception("Lỗi cập nhật tài khoản");
                }
            }
        }
    }
}
