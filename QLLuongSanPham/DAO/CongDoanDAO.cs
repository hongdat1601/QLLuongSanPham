using System;
using System.Collections.Generic;
using System.Linq;
using QLLuongSanPham.Entities;

namespace QLLuongSanPham.DAO
{
    class CongDoanDAO
    {
        private QLLuongSPContext context;

        public CongDoanDAO()
        {
            context = new QLLuongSPContext();
        }

        public IEnumerable<CongDoan> GetCongDoans() => context.CongDoan;

        public IEnumerable<CongDoan> GetCongDoansByIdSanPham(int id)
        {
            return context.CongDoan.Where(x => x.IDSanPham == id);
        }
        public CongDoan GetById(int id)
        {
            return context.CongDoan
                .Where(x => x.ID == id)
                .FirstOrDefault();
        }

        public CongDoan GetByName(string name)
        {
            return context.CongDoan
                .Where(x => x.TenCongDoan.Equals(name))
                .FirstOrDefault();
        }

        public bool Add(CongDoan cd)
        {
            using (var tran = context.Database.BeginTransaction())
            {
                try
                {
                    context.CongDoan.Add(cd);
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

        public bool Delete(CongDoan cd)
        {
            using (var tran = context.Database.BeginTransaction())
            {
                try
                {
                    context.CongDoan.Remove(cd);
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

        public bool Update(CongDoan cdNew)
        {

            using (var tran = context.Database.BeginTransaction())
            {
                try
                {
                    var cd = GetById(cdNew.ID);

                    cd.TenCongDoan = cdNew.TenCongDoan;
                    cd.DonGia = cdNew.DonGia;

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
