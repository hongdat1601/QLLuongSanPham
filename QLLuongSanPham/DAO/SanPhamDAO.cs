using QLLuongSanPham.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLLuongSanPham.DAO
{
    class SanPhamDAO
    {
        private QLLuongSPContext context;

        public SanPhamDAO()
        {
            context = new QLLuongSPContext();
        }

        public IEnumerable<SanPham> GetSanPhams() => context.SanPham;
    }
}
