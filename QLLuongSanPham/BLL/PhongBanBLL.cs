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

    }
}
