using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using QLLuongSanPham.Entities;

namespace QLLuongSanPham.DAO
{
    class PhongBanDAO
    {
        private QLLuongSPContext context;

        public PhongBanDAO()
        {
            context = new QLLuongSPContext();
        }

        public IEnumerable<PhongBan> GetPhongBans() => context.PhongBan;

        public IEnumerable<PhongBan> GetListPBByName(string name)
        {
            return context.PhongBan
                .Where(x => x.TenPhongBan.Contains(name));
        }

        public PhongBan GetById(int id)
        {
            return context.PhongBan
                .Where(x => x.ID == id)
                .FirstOrDefault();
        }

        public int GetIDByName(string name)
        {
            return context.PhongBan
                .Where(x => x.TenPhongBan == name)
                .FirstOrDefault().ID;
        }

        public string GetNameByID(int id)
        {
            return context.PhongBan
                .Where(x => x.ID == id)
                .FirstOrDefault().TenPhongBan;
        }

        public bool Add(PhongBan pb)
        {
            using (var tran = context.Database.BeginTransaction())
            {
                try
                {
                    context.PhongBan.Add(pb);
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

        public bool Delete(PhongBan pb)
        {
            using (var tran = context.Database.BeginTransaction())
            {
                try
                {
                    context.PhongBan.Remove(pb);
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

        public bool Update(PhongBan pbNew)
        {

            using (var tran = context.Database.BeginTransaction())
            {
                try
                {
                    var pb = GetById(pbNew.ID);

                    pb.TenPhongBan = pbNew.TenPhongBan;
                    pb.NgayThanhLap = pbNew.NgayThanhLap;
                    pb.TenQuanLy = pbNew.TenQuanLy;

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
