using System;
using System.Collections.Generic;
using System.Linq;
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

        public IEnumerable<SanPham> GetSPByChar(string input)
        {
            return context.SanPham.Where(x => x.TenSP.Contains(input));
        }
        public SanPham GetById(int id)
        {
            return context.SanPham
                .Where(x => x.ID == id)
                .FirstOrDefault();
        }

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

        public IQueryable<SanPham> FindByNameAndPrice(string name, string _price)
        {
            decimal price = -1;

            if (!string.IsNullOrEmpty(_price))
            {
                price = Convert.ToDecimal(_price);
            }

            if (price == -1)
                return context.SanPham
                    .Where(x => x.TenSP.Contains(name));
            else
                return context.SanPham
                    .Where(x => x.TenSP.Contains(name) && x.DonGia == price);
        }
    }
}
