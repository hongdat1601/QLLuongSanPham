using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using QLLuongSanPham.DAL;

namespace QLLuongSanPham.BLL
{
    class ChucVuBLL : ConnectionBLL
    {
        public ChucVuBLL()
        {

        }

        public ChucVu GetById(int id)
        {
            return context.ChucVus
                .Where(x => x.ID == id)
                .FirstOrDefault();
        }
    }
}
