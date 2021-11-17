using QLLuongSanPham.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLLuongSanPham.DAO
{
    class CongDoanDAO
    {
        private QLLuongSPContext context;

        public CongDoanDAO()
        {
            context = new QLLuongSPContext();
        }

        public IEnumerable<CongDoan> GetCongDoans() => context.CongDoans;

        public IEnumerable<CongDoan> GetCongDoansByIdSanPham(int id)
        {
            return context.CongDoans.Where(x => x.IDSanPham == id);
        }
        public CongDoan GetById(int id)
        {
            return context.CongDoans
                .Where(x => x.ID == id)
                .FirstOrDefault();
        }

        public CongDoan GetByName(string name)
        {
            return context.CongDoans
                .Where(x => x.TenCongDoan.Equals(name))
                .FirstOrDefault();
        }

        public bool Add(CongDoan cd)
        {
            using (var tran = context.Database.BeginTransaction())
            {
                try
                {
                    context.CongDoans.Add(cd);
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
                    context.CongDoans.Remove(cd);
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
