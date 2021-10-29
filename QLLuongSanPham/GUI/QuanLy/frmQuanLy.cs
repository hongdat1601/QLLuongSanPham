﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLLuongSanPham.GUI.QuanLy
{
    public partial class frmQuanLy : Form
    {
        private Form activeForm = null;
        private Button activeBtn = null;
        private Panel activePnl = null;

        public frmQuanLy()
        {
            InitializeComponent();
        }

        #region Methods
        private void OpenFormChild(Form formChild)
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
            pnlCapNhat.Visible = false;
            pnlXuLy.Visible = false;
            pnlTimKiem.Visible = false;
            pnlThongKe.Visible = false;
            OpenFormChild(new frmTongQuan());
        }

        private void FocusBtn(Button btn)
        {
            if(activeBtn != null)
            {
                activeBtn.BackColor = (Color)Constant.Colors["primary"];
            }
            activeBtn = btn;
            activeBtn.BackColor = (Color)Constant.Colors["btnFocus"];
        }

        private void ToggleMenu(Panel pnl)
        {
            if(activePnl == null)
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

        #endregion

        #region Events
        private void frmQuanLy_Load(object sender, EventArgs e)
        {
            SettingDefault();
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
            else if (btn.Equals(btnCapNhat))
            {
                FocusBtn(btnCapNhat);
                ToggleMenu(pnlCapNhat);
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

        }

        private void btnXuLyChamCong_Click_1(object sender, EventArgs e)
        {

        }

        private void btnXuLyPhanCa_Click(object sender, EventArgs e)
        {

        }

        private void btnThongKeHC_Click(object sender, EventArgs e)
        {

        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {

        }

        private void btnHopDong_Click(object sender, EventArgs e)
        {

        }

        private void btnPhongBan_Click(object sender, EventArgs e)
        {
            OpenFormChild(new frmPhongBan());
        }

        private void btnCaLam_Click(object sender, EventArgs e)
        {

        }

        private void btnCongDoan_Click(object sender, EventArgs e)
        {

        }

        private void btnXuLyChamCong_Click(object sender, EventArgs e)
        {

        }

        private void btnXuLyTinhLuong_Click(object sender, EventArgs e)
        {

        }

        private void btnTimKiemNV_Click(object sender, EventArgs e)
        {

        }

        private void btnTimKiemSP_Click(object sender, EventArgs e)
        {

        }

        private void btnTimKiemPB_Click(object sender, EventArgs e)
        {

        }

        private void btnTimKiemHD_Click(object sender, EventArgs e)
        {

        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {

        }

        private void btnThongKeSP_Click(object sender, EventArgs e)
        {

        }

        private void btnThongKeCT_Click(object sender, EventArgs e)
        {

        }

        #endregion

    }
}