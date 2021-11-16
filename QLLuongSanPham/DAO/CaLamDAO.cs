using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLLuongSanPham.Entities;
namespace QLLuongSanPham.DAO
{
    class CaLamDAO
    {
        private QLLuongSPContext context;

        public CaLamDAO()
        {
            context = new QLLuongSPContext();
        }

        public IEnumerable<CaLam> GetCaLams() => context.CaLams;
        public IEnumerable<CaLam> GetCaByIDSP(int id)
        {
            return context.CaLams
                .Where(x => x.ID == id);
        }

        public CaLam GetByID(int id)
        {
            return context.CaLams
                .Where(x => x.ID.Equals(id))
                .FirstOrDefault();
        }

        public int GetIDByName(string name)
        {
            var ca = GetCaLams().Where(x => x.TenCa == name).FirstOrDefault();

            if (ca == null)
                return -1;
            else
                return ca.ID;
        }

        public bool AddCaLam(CaLam ca)
        {
            using (var db = context.Database.BeginTransaction())
            {
                try
                {
                    context.CaLams.Add(ca);
                    context.SaveChanges();
                    db.Commit();
                    return true;
                }
                catch (Exception)
                {
                    db.Rollback();
                    throw new Exception("Lỗi thêm ca làm");
                }
            }
        }

        public bool RemoveCaLam(CaLam ca)
        {
            using (var db = context.Database.BeginTransaction())
            {
                try
                {
                    context.CaLams.Remove(ca);
                    context.SaveChanges();
                    db.Commit();

                    return true;
                }
                catch (Exception)
                {
                    db.Rollback();
                    throw new Exception("Lỗi xóa ca làm");
                }
            }
        }

        public bool EditCaLam(CaLam ca)
        {
            using (var db = context.Database.BeginTransaction())
            {
                try
                {
                    var update = from i in context.CaLams
                                 where i.ID == ca.ID
                                 select i;
                    update.First().TenCa = ca.TenCa;
                    update.First().ThoiGianLam = ca.ThoiGianLam;
                    context.SaveChanges();
                    db.Commit();

                    return true;
                }
                catch (Exception)
                {
                    db.Rollback();
                    throw new Exception("Lỗi xóa ca làm");
                }
            }
        }
    }
}
