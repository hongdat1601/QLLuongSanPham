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

        public IEnumerable<SanPham> GetSanPhams() => context.SanPhams;

        public IEnumerable<SanPham> GetSPByChar(string input)
        {
            return context.SanPhams.Where(x => x.TenSP.Contains(input));
        }
        public SanPham GetById(int id)
        {
            return context.SanPhams
                .Where(x => x.ID == id)
                .FirstOrDefault();
        }

        public bool AddProcduct(SanPham sp)
        {
            using (var db = context.Database.BeginTransaction())
            {
                try
                {
                    context.SanPhams.Add(sp);
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
                    context.SanPhams.Remove(sp);
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
                return context.SanPhams
                    .Where(x => x.TenSP.Contains(name));
            else
                return context.SanPhams
                    .Where(x => x.TenSP.Contains(name) && x.DonGia == price);
        }
    }
}
