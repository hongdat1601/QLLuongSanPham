using QLLuongSanPham.GUI.QuanLy;
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
using QLLuongSanPham.DAO;
using QLLuongSanPham.GUI.NhanVienGUI;

namespace QLLuongSanPham.GUI
{
    public partial class frmDangNhap : Form
    {
        private TaiKhoanDAO tkDAO;
        NhanVienDAO nvDAO;
        public frmDangNhap()
        {
            InitializeComponent();
            tkDAO = new TaiKhoanDAO();
            nvDAO = new NhanVienDAO();
        }

        //Methods
        // Envents
        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("Thoát khỏi chương trình.", "Thông báo", MessageBoxButtons.YesNo);

            if (msg == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Yes;
                this.Close();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            TaiKhoan taiKhoan = tkDAO.GetTaiKhoanByID(txtUsername.Text);

            if (taiKhoan != null && taiKhoan.Password != txtPassword.Text)
            {
                MessageBox.Show("Sai mật khẩu hoặc tên đăng nhập.Vui lòng nhập lại !", "Thông báo");
                return;
            }

            string name = taiKhoan.Username.Substring(0,2);
            NhanVien nv = nvDAO.GetById(taiKhoan.IDNhanVien.Value);

            if (name == "QL")
            {
                frmQuanLy frm = new frmQuanLy();
                //this.Hide();

                if (frm.ShowDialog() == DialogResult.Yes)
                    this.Close();
                else
                    this.Show();
            }
            else
            {
                frmNVChinh frm = new frmNVChinh(nv);
                
                if (frm.ShowDialog() == DialogResult.Yes)
                    this.Close();
                else
                    this.Show();
                //this.Hide();
            }
        }


    }
}
