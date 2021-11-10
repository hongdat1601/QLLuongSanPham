using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLLuongSanPham.Entities;

namespace QLLuongSanPham.GUI.NhanVienGUI
{
    public partial class frmThongtinNV : Form
    {
        private NhanVien nhanVien;
        public frmThongtinNV(NhanVien nhanVien)
        {
            InitializeComponent();
            this.nhanVien = nhanVien;
        }

        private void btnFixPassWord_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau frm = new frmDoiMatKhau();
            frm.Show();
        }

        private void frmThongtinNV_Load(object sender, EventArgs e)
        {
            if(nhanVien.IDChucVu == 7)
            {
                gbxInfoSlary.Visible = false;
            }
        }
    }
}
