using System;
using System.Windows.Forms;
using QLLuongSanPham.Entities;

namespace QLLuongSanPham.GUI.NhanVienGUI
{
    public partial class frmTongQuan : Form
    {
        private NhanVien _nv;
        public frmTongQuan(NhanVien nv)
        {
            InitializeComponent();
            this._nv = nv;
        }

        private void frmTongQuan_Load(object sender, EventArgs e)
        {
            lblName.Text = "Chào mừng nhân viên " + _nv.HoTen;
        }
    }
}
