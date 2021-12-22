using System;
using System.Collections.Generic;
using System.Linq;
using QLLuongSanPham.Entities;

namespace QLLuongSanPham.DAO
{
    class BangCongCNDAO
    {
        private QLLuongSPContext context;

        public BangCongCNDAO()
        {
            context = new QLLuongSPContext();
        }

        public IEnumerable<BangCongSP> GetBangCongSPs() => context.BangCongSP;

        public IEnumerable<BangCongSP> GetByIDCd(int id)
        {
            return context.BangCongSP
                .Where(x => x.IDCongDoan == id);
        }
        public BangCongSP GetByID(int id)
        {
            return context.BangCongSP
                .Where(x => x.ID == id)
                .FirstOrDefault();
        }

        public bool AddBCCN(BangCongSP bc)
        {
            using (var db = context.Database.BeginTransaction())
            {
                try
                {
                    context.BangCongSP.Add(bc);
                    context.SaveChanges();
                    db.Commit();
                    return true;
                }
                catch (Exception)
                {
                    db.Rollback();
                    throw new Exception("Lỗi thêm bảng công cho công nhân");
                }

            }
        }

        public bool RemoveBCCN(BangCongSP bc)
        {
            using (var db = context.Database.BeginTransaction())
            {
                try
                {
                    context.BangCongSP.Remove(bc);
                    context.SaveChanges();
                    db.Commit();
                    return true;
                }
                catch (Exception)
                {
                    db.Rollback();
                    throw new Exception("Lỗi xóa bảng công cho công nhân");
                }
            }
        }

        public bool UpdateBCCN(BangCongSP bc_new)
        {
            using (var db = context.Database.BeginTransaction())
            {
                try
                {
                    var bc = GetByID(bc_new.ID);

                    bc.SoLuongSP = bc_new.SoLuongSP;

                    context.SaveChanges();
                    db.Commit();
                    return true;
                }
                catch (Exception)
                {
                    db.Rollback();
                    throw new Exception("Lỗi cập nhật bảng công cho công nhân");
                }
            }
        }

        public IEnumerable<BangCongSP> GetBangCongSPsByDateAndCa(string date, int idCa)
        {
            var bc = GetBangCongSPs().Where(x => x.NgayDiLam.Value.ToString("dd/MM/yyyy").Contains(date));

            if (idCa != -1)
            {
                bc = bc.Where(x => x.IDCaLam == idCa);
            }

            return bc;
        }

        public IEnumerable<BangCongSP> GetBangCongSPsByIDNhanVien(int idNhanVien)
        {
            return GetBangCongSPs().Where(x => x.ID_NhanVien == idNhanVien);
        }

    }
}
