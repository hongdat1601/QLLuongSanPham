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
    public partial class frmTongQuan : Form
    {
        private NhanVien nhanVien;
        public frmTongQuan(NhanVien nhanVien)
        {
            InitializeComponent();
            this.nhanVien = nhanVien;
        }

        private void btnInfoDesktop_Click(object sender, EventArgs e)
        {
            this.Close();
            frmThongtinNV frm = new frmThongtinNV(nhanVien);
            
        }

        private void btnSalaryDestop_Click(object sender, EventArgs e)
        {

        }
    }
}
