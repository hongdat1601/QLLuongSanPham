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

        public IEnumerable<ChucVu> GetChucVus() => context.ChucVu;

        public ChucVu GetChucByID(int id)
        {
            return context.ChucVu
                .Where(x => x.ID == id)
                .FirstOrDefault();
        }

        public int GetIDByName(string name)
        {
            var q = from i in context.ChucVu
                     where i.TenChucVu.Equals(name)
                     select i.ID;

            int id = q.FirstOrDefault();
            return id;
        }

        public string GetNameByID(int id)
        {
            string name;
            var q = from i in context.ChucVu
                    where i.ID == id
                    select i.TenChucVu;
            name = q.FirstOrDefault();

            return name;
        }
    }
}
