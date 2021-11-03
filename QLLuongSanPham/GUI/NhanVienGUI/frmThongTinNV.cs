using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLLuongSanPham.GUI.NhanVienGUI
{
    public partial class frmThongtinNV : Form
    {
        public frmThongtinNV()
        {
            InitializeComponent();
        }

        private void btnFixPassWord_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau frm = new frmDoiMatKhau();
            frm.Show();
        }
    }
}
