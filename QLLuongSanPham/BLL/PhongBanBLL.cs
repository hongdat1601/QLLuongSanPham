using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLLuongSanPham.DAL;

namespace QLLuongSanPham.BLL
{
    class PhongBanBLL : ConnectionBLL
    {
        public PhongBanBLL() 
        {

        }

        public IEnumerable<PhongBan> GetPhongBans() => context.PhongBans;

        public PhongBan GetById(int id)
        {
            return context.PhongBans
                .Where(x => x.ID == id)
                .FirstOrDefault();
        }

        public bool AddPhongBan(PhongBan pb)
        {
            
            using (var trans = context.Connection.BeginTransaction())
            {
                context.Transaction = trans;

                try
                {
                    context.PhongBans.InsertOnSubmit(pb);
                    context.SubmitChanges();
                    trans.Commit();
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    throw ex;
                }

            }

            return true;
        }

        public bool DeletePhongBan(int id)
        {
            PhongBan pb = GetById(id);

            using (var trans = context.Connection.BeginTransaction())
            {
                context.Transaction = trans;

                try
                {
                    context.PhongBans.DeleteOnSubmit(pb);
                    context.SubmitChanges();
                    trans.Commit();
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    throw ex;
                }

            }

            return true;
        }

        public bool UpdatePhongBan(PhongBan pbNew)
        {
            using (var trans = context.Connection.BeginTransaction())
            {
                context.Transaction = trans;

                try
                {
                    PhongBan pb = context.PhongBans.Single(x => x.ID == pbNew.ID);
                    pb.TenPhongBan = pbNew.TenPhongBan;
                    context.SubmitChanges();
                    trans.Commit();
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    throw ex;
                }

            }

            return true;
        }
    }
}
