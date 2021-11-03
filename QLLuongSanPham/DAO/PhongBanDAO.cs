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

    }
}
