﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLLuongSanPham.Entities;

namespace QLLuongSanPham.DAO
{
    class LoaiPhepDAO
    {
        private QLLuongSPContext context;
        public LoaiPhepDAO()
        {
            context = new QLLuongSPContext();
        }

        public IEnumerable<LoaiPhep> GetLoaiPheps() => context.LoaiPhep;

        public LoaiPhep GetByID(int id)
        {
            return context.LoaiPhep
                .Where(x => x.ID == id)
                .FirstOrDefault();
        }
    }
}
