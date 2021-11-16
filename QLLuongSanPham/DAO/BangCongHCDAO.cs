﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLLuongSanPham.Entities; 

namespace QLLuongSanPham.DAO
{
    class BangCongHCDAO
    {
        private QLLuongSPContext context;

        public BangCongHCDAO()
        {
            context = new QLLuongSPContext();
        }

        public IEnumerable<BangCongHC> GetBangCongHCs() => context.BangCongHCs;

        public BangCongHC GetByID(int id)
        {
            return context.BangCongHCs
                .Where(x => x.ID == id)
                .FirstOrDefault();
        }

        public IEnumerable<BangCongHC> GetBCByIDNV(int id)
        {
            return context.BangCongHCs
                .Where(x=> x.IDNhanVien == id);
        }
        public bool AddLich(BangCongHC lich)
        {
            using (var db = context.Database.BeginTransaction())
            {
                try
                {
                    context.BangCongHCs.Add(lich);
                    context.SaveChanges();
                    db.Commit();
                    return true;
                }
                catch (Exception)
                {
                    db.Rollback();
                    throw new Exception("Lỗi thêm lịch");
                }
               
            }
        }

        public bool UpdateBangCong(BangCongHC bcNew)
        {
            using (var db = context.Database.BeginTransaction())
            {
                try
                {
                    var bc = GetByID(bcNew.ID);
                    bc.TrangThai = bcNew.TrangThai;
                    bc.IDLoaiPhep = bcNew.IDLoaiPhep;

                    context.SaveChanges();
                    db.Commit();
                }
                catch (Exception)
                {
                    db.Rollback();
                    return false;
                }
            }

            return true;
        }

        public bool RemoveBangCong(BangCongHC bc)
        {
            using (var db = context.Database.BeginTransaction())
            {
                try
                {
                    context.BangCongHCs.Remove(bc);
                    context.SaveChanges();
                    db.Commit();
                    return true;
                }
                catch (Exception)
                {
                    db.Rollback();
                    throw new Exception("Lỗi sữa nhân viên");
                }
            }
        }

        public IEnumerable<BangCongHC> GetBangCongHCsByDate(string date)
        {
            return GetBangCongHCs().Where(x => x.NgayCham.Value.ToString("dd/MM/yyyy").Contains(date));
        }

        public IEnumerable<BangCongHC> GetBangCongHCsByIDNVAndDate(int id, int month, int year)
        {
            return context.BangCongHCs
                .Where(x => x.IDNhanVien == id 
                && x.NgayCham.Value.Month == month
                && x.NgayCham.Value.Year == year);
        }
    }
}
