using System;
using System.Drawing;
using System.Windows.Forms;
using QLLuongSanPham.DAO;
using QLLuongSanPham.Entities;

namespace QLLuongSanPham.GUI.QuanLy
{
    public partial class frmQuanLy : Form
    {
        private Form activeForm = null;
        private Button activeBtn = null;
        private Panel activePnl = null;
        private Button activeSubBtn = null;
        private NhanVien _nv;
        NhanVienDAO nvDAO;

        public frmQuanLy(NhanVien nv)
        {
            InitializeComponent();
            this._nv = nv;
            nvDAO = new NhanVienDAO();
        }

        #region Methods
        public void OpenFormChild(Form formChild)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = formChild;
            formChild.TopLevel = false;
            formChild.Dock = DockStyle.Fill;

            pnlBody.Controls.Add(activeForm);
            activeForm.BringToFront();
            activeForm.Show();

        }

        private void SettingDefault()
        {
            pnlDanhMuc.Visible = false;
            pnlXuLy.Visible = false;
            pnlTimKiem.Visible = false;
            pnlThongKe.Visible = false;
        }

        private void FocusBtn(Button btn)
        {
            if (activeBtn != null)
            {
                activeBtn.BackColor = (Color)Constant.Colors["primary"];
            }
            activeBtn = btn;
            activeBtn.BackColor = (Color)Constant.Colors["btnFocus"];
        }

        private void ToggleMenu(Panel pnl)
        {
            if (activePnl == null)
            {
                activePnl = pnl;
                activePnl.Visible = true;
            }
            else if (activePnl.Equals(pnl))
            {
                activePnl.Visible = !activePnl.Visible;
            }
            else
            {
                activePnl.Visible = false;
                activePnl = pnl;
                activePnl.Visible = true;
            }

        }

        private void FocusSubBtn(Button btn)
        {
            if (activeSubBtn == null || !activeSubBtn.Equals(btn))
            {
                if (activeSubBtn != null)
                    activeSubBtn.BackColor = (Color)Constant.Colors["btnSub"];

                activeSubBtn = btn;
                activeSubBtn.BackColor = (Color)Constant.Colors["btnSubFocus"];
            }

        }

        #endregion

        #region Events
        private void frmQuanLy_Load(object sender, EventArgs e)
        {
            SettingDefault();
            lblWelcome.Text = "Chào mừng quản lý " + nvDAO.GetById(_nv.ID).HoTen;
            txtTen.Text = nvDAO.GetById(_nv.ID).HoTen;
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("Đăng xuất khỏi chương trình.", "Thông báo", MessageBoxButtons.YesNo);

            if (msg == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.No;
                this.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)

        {
            DialogResult msg = MessageBox.Show("Thoát khỏi chương trình.", "Thông báo", MessageBoxButtons.YesNo);

            if (msg == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Yes;
                this.Close();
            }
        }

        private void btnClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn.Equals(btnThongKe))
            {
                FocusBtn(btnThongKe);
                ToggleMenu(pnlThongKe);
            }
            else if (btn.Equals(btnXuLy))
            {
                FocusBtn(btnXuLy);
                ToggleMenu(pnlXuLy);
            }
            else if (btn.Equals(btnTimKiem))
            {
                FocusBtn(btnTimKiem);
                ToggleMenu(pnlTimKiem);
            }
            else
            {
                FocusBtn(btnDanhMuc);
                ToggleMenu(pnlDanhMuc);
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnXuLyTinhLuong_Click_1(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (activeSubBtn == null || !activeSubBtn.Equals(btn))
            {
                OpenFormChild(new frmTinhLuong());
            }
            FocusSubBtn(btn);
        }

        private void btnXuLyChamCong_Click_1(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (activeSubBtn == null || !activeSubBtn.Equals(btn))
            {
                OpenFormChild(new frmChamCong());
            }
            FocusSubBtn(btn);
        }

        private void btnXuLyPhanCa_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (activeSubBtn == null || !activeSubBtn.Equals(btn))
            {
                OpenFormChild(new frmPhanLichCN());
            }
            FocusSubBtn(btn);
        }

        private void btnThongKeHC_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (activeSubBtn == null || !activeSubBtn.Equals(btn))
            {
                OpenFormChild(new frmThongKeHC());
            }
            FocusSubBtn(btn);
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (activeSubBtn == null || !activeSubBtn.Equals(btn))
            {
                OpenFormChild(new frmSanPham());
            }
            FocusSubBtn(btn);
        }

        private void btnHopDong_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (activeSubBtn == null || !activeSubBtn.Equals(btn))
            {
                OpenFormChild(new frmHopDong());
            }
            FocusSubBtn(btn);
        }

        private void btnPhongBan_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (activeSubBtn == null || !activeSubBtn.Equals(btn))
            {
                OpenFormChild(new frmPhongBan());
            }
            FocusSubBtn(btn);
        }

        private void btnCaLam_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (activeSubBtn == null || !activeSubBtn.Equals(btn))
            {
                OpenFormChild(new frmCaLamViec());
            }
            FocusSubBtn(btn);
        }

        private void btnCongDoan_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (activeSubBtn == null || !activeSubBtn.Equals(btn))
            {
                OpenFormChild(new frmCongDoan());
            }
            FocusSubBtn(btn);
        }

        private void btnXuLyChamCong_Click(object sender, EventArgs e)
        {

        }

        private void btnXuLyTinhLuong_Click(object sender, EventArgs e)
        {

        }

        private void btnTimKiemNV_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (activeSubBtn == null || !activeSubBtn.Equals(btn))
            {
                OpenFormChild(new frmTimKiemNV());
            }
            FocusSubBtn(btn);
        }

        private void btnTimKiemSP_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (activeSubBtn == null || !activeSubBtn.Equals(btn))
            {
                OpenFormChild(new frmTimKiemSP());
            }
            FocusSubBtn(btn);
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (activeSubBtn == null || !activeSubBtn.Equals(btn))
            {
                OpenFormChild(new frmNhanVien());
            }
            FocusSubBtn(btn);
        }

        private void btnThongKeSP_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (activeSubBtn == null || !activeSubBtn.Equals(btn))
            {
                OpenFormChild(new frmThongKeSP());
            }
            FocusSubBtn(btn);
        }

        private void btnThongKeCT_Click(object sender, EventArgs e)
        {

        }

        #endregion
    }
}
