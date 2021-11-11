﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using QLLuongSanPham.Entities;

namespace QLLuongSanPham.DAO
{
    class NhanVienDAO
    {
        private QLLuongSPContext context;

        public NhanVienDAO()
        {
            context = new QLLuongSPContext();
        }

        public IEnumerable<NhanVien> GetNhanViens() => context.NhanVien;

        public IEnumerable<NhanVien> GetListNVByID(int id)
        {
            return context.NhanVien.Where(x => x.ID == id);
        }

        public IEnumerable<NhanVien> GetListNVByName(string name)
        {
            return context.NhanVien.Where(x => x.HoTen.Contains(name));
        }

        public NhanVien GetById(int id)
        {
            return context.NhanVien
                .Where(x => x.ID == id)
                .FirstOrDefault();
        }

        public bool AddEmployee(NhanVien nv)
        {
            using(var db = context.Database.BeginTransaction())
            {
                try
                {
                    context.NhanVien.Add(nv);
                    context.SaveChanges();
                    db.Commit();
                    return true;
                }
                catch (Exception)
                {
                    db.Rollback();
                    throw new Exception("Lỗi thêm nhân viên");
                }
            }
        }

        public bool RemoveEmployee(NhanVien nv)
        {
            using (var db = context.Database.BeginTransaction())
            {
                try
                {
                    context.NhanVien.Remove(nv);
                    context.SaveChanges();
                    db.Commit();
                    return true;
                }
                catch (Exception)
                {
                    db.Rollback();
                    throw new Exception("Lỗi xóa nhân viên");
                }
            }
        }

        public bool UpdateEmployee(NhanVien nv)
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

        public IEnumerable<NhanVien> Find(string ten, 
            string sdt, 
            string ngaySinh, 
            bool gioiTinh,
            string cmnd,
            string diaChi,
            int idPB,
            int idCV,
            int idHV,
            int thamNien)
        {
            IEnumerable<NhanVien> nv = context.NhanVien;

            nv = nv.Where(x => x.HoTen.Contains(ten)
            && x.CMND.Contains(cmnd)
            && x.SDT.Contains(sdt)
            && x.GioiTinh == gioiTinh
            && x.NgaySinh.Value.ToString("dd/MM/yyyy").Contains(ngaySinh)
            && x.DiaChi.Contains(diaChi));

            if (idPB != -1)
                nv = nv.Where(x => x.IDPhongBan == idPB);
            if (idCV != -1)
                nv = nv.Where(x => x.IDTrinhDoHocVan == idHV);
            if (idCV != -1)
                nv = nv.Where(x => x.IDChucVu == idCV);
            if (thamNien != -1)
                nv = nv.Where(x => x.ThamNienCongTac == thamNien);

            return nv;
        }
    }
}
