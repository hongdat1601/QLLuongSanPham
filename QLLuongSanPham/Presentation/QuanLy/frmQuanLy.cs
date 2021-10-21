using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLLuongSanPham.Presentation.QuanLy
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
            pnlChamCong.Visible = false;
            pnlQLNhanSu.Visible = false;
            pnlQLSanPham.Visible = false;
            pnlThongKe.Visible = false;
            pnlTinhLuong.Visible = false;

            btnTongQuan.Focus();
            FocusBtn(btnTongQuan);
            activeBtn = btnTongQuan;
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

        private void ToggleSubMenu(Panel pnl)
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

        private void btnTongQuan_Click(object sender, EventArgs e)
        {
            if (!activeBtn.Equals(btnTongQuan))
            {
                FocusBtn((Button)sender);
                OpenFormChild(new frmTongQuan());
            }
        }

        private void btnQLPhongBan_Click(object sender, EventArgs e)
        {
            if(!activeBtn.Equals(btnQLPhongBan))
            {
                FocusBtn((Button)sender);
                OpenFormChild(new frmQLPhongBan());
            }
        }

        private void btnLapHopDong_Click(object sender, EventArgs e)
        {
            FocusBtn((Button)sender);
        }

        private void btnQLSanPham_Click(object sender, EventArgs e)
        {
            FocusBtn((Button)sender);
            ToggleSubMenu(pnlQLSanPham);
        }

        private void btnQLNhanSu_Click(object sender, EventArgs e)
        {
            FocusBtn((Button)sender);
            ToggleSubMenu(pnlQLNhanSu);
        }

        private void btnChamCong_Click(object sender, EventArgs e)
        {
            FocusBtn((Button)sender);
            ToggleSubMenu(pnlChamCong);
        }

        private void btnTinhLuong_Click(object sender, EventArgs e)
        {
            FocusBtn((Button)sender);
            ToggleSubMenu(pnlTinhLuong);
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            FocusBtn((Button)sender);
            ToggleSubMenu(pnlThongKe);
        }
        #endregion

    }
}
