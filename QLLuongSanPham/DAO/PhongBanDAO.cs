﻿using System;
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

        public PhongBan GetDepByID(int id)
        {
            return context.PhongBan
                .Where(x => x.ID == id)
                .FirstOrDefault();
        }

        public int GetIDByName(string name)
        {
            var q = from i in context.PhongBan
                    where i.TenPhongBan.Equals(name)
                    select i.ID;
            int id = q.FirstOrDefault();
            return id;
        }

        public string GetNameByID(int id)
        {
            string name;
            var q = from i in context.PhongBan
                    where i.ID == id
                    select i.TenPhongBan;
            name = q.FirstOrDefault();

            return name;
        }
    }
}
