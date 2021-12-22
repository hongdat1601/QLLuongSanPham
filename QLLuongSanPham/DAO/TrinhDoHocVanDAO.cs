using System.Collections.Generic;
using System.Linq;
using QLLuongSanPham.Entities;
namespace QLLuongSanPham.DAO
{
    class TrinhDoHocVanDAO
    {
        private QLLuongSPContext context;

        public TrinhDoHocVanDAO()
        {
            context = new QLLuongSPContext();
        }

        public IEnumerable<TrinhDoHocVan> GetTrinhDoHocVans() => context.TrinhDoHocVan;

        public TrinhDoHocVan GetHVByID(int id)
        {
            return context.TrinhDoHocVan
                .Where(x => x.ID == id)
                .FirstOrDefault();
        }

        public int GetIDByName(string name)
        {
            var q = context.TrinhDoHocVan
                .Where(x => x.TenTrinhDo == name)
                .FirstOrDefault();

            if (q == null)
                return -1;
            else
                return q.ID;
        }

        public string GetNameByID(int id)
        {
            string name;
            var q = from i in context.TrinhDoHocVan
                    where i.ID == id
                    select i.TenTrinhDo;
            name = q.FirstOrDefault();

            return name;
        }
    }
}
