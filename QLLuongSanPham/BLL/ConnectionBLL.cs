using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLLuongSanPham.DAL;

namespace QLLuongSanPham.BLL
{
    class ConnectionBLL
    {
        protected QLLuongSPDataContext context;
        private string connection = @"Data Source=VOMINHPHUONG;Initial Catalog=QLLuongSP;Integrated Security=True";

        public ConnectionBLL()
        {
            context = new QLLuongSPDataContext(connection);
            context.Connection.Open();
        }
    }
}
