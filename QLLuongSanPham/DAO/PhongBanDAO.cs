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

        public IEnumerable<PhongBan> GetPhongBans() => context.PhongBans;

        public IEnumerable<PhongBan> GetListPBByName(string name)
        {
            return context.PhongBans
                .Where(x => x.TenPhongBan.Contains(name));
        }

        public PhongBan GetById(int id)
        {
            return context.PhongBans
                .Where(x => x.ID == id)
                .FirstOrDefault();
        }

        public int GetIDByName(string name)
        {
            var pb = context.PhongBans
                .Where(x => x.TenPhongBan == name)
                .FirstOrDefault();

            if (pb == null)
                return -1;
            else return pb.ID;
                
        }

        public string GetNameByID(int id)
        {
            return context.PhongBans
                .Where(x => x.ID == id)
                .FirstOrDefault().TenPhongBan;
        }

        public bool Add(PhongBan pb)
        {
            using (var tran = context.Database.BeginTransaction())
            {
                try
                {
                    context.PhongBans.Add(pb);
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
                    context.PhongBans.Remove(pb);
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

        public void UpdateSLNV(int idPhongBan)
        {
            var pb = GetById(idPhongBan);
            if (pb != null)
            {
                pb.SoLuongNhanVien++;
                context.SaveChanges();
            }
        }

    }
}
