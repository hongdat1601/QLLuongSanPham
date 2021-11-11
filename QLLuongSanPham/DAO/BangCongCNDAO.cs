﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        
        public BangCongSP GetByID(int id)
        {
            return context.BangCongSP
                .Where(x => x.ID == id)
                .FirstOrDefault();
        }

        public BangCongSP GetByIDCD(int id)
        {
            return context.BangCongSP
                .Where(x => x.IDCongDoan == id)
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

        public bool UpdateBCCN(BangCongSP bc)
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
                    throw new Exception("Lỗi cập nhật bảng công cho công nhân");
                }
            }
        }

    }
}
