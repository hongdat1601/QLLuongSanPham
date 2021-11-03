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

        public NhanVien GetById(int id)
        {
            return context.NhanVien
                .Where(x => x.ID == id)
                .FirstOrDefault();
        }
    }
}
