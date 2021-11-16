using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLLuongSanPham.Entities;

namespace QLLuongSanPham.DAO
{
    class ChucVuDAO
    {
        private QLLuongSPContext context;

        public ChucVuDAO()
        {
            context = new QLLuongSPContext();
        }

        public IEnumerable<ChucVu> GetChucVus() => context.ChucVus;

        public ChucVu GetChucByID(int id)
        {
            return context.ChucVus
                .Where(x => x.ID == id)
                .FirstOrDefault();
        }

        public int GetIDByName(string name)
        {
            var q = context.ChucVus
                .Where(x => x.TenChucVu == name)
                .FirstOrDefault();

            if (q == null)
                return -1;
            else
                return q.ID;
        }

        public string GetNameByID(int id)
        {
            string name;
            var q = from i in context.ChucVus
                    where i.ID == id
                    select i.TenChucVu;
            name = q.FirstOrDefault();

            return name;
        }
    }
}
