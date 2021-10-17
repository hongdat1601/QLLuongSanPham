using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLLuongSanPham
{
    public partial class frmManagement : Form
    {
        public frmManagement()
        {
            InitializeComponent();
        }

        #region Method

        private void HideSubMenu(Panel panel)
        {
            panel.Visible = false;
        }

        private void ShowSubMenu(Button button, Panel panel)
        {
            FocusButton(button);
            
            if(!panel.Equals(pnlSeperate))
            {
                panel.Visible = true;
                FocusSubButton((Button)panel.Controls[panel.Controls.Count - 1], panel);
            }

            if (button.Equals(btnQLNhanSu))
            {
                panel.Visible = true;
                HideSubMenu(pnlChamCong);
                HideSubMenu(pnlTinhLuong);
                HideSubMenu(pnlThongKe);
            }
            else if (button.Equals(btnChamCong))
            {
                panel.Visible = true;
                HideSubMenu(pnlQLNhanSu);
                HideSubMenu(pnlTinhLuong);
                HideSubMenu(pnlThongKe);
            }
            else if (button.Equals(btnTinhLuong))
            {
                panel.Visible = true;
                HideSubMenu(pnlQLNhanSu);
                HideSubMenu(pnlChamCong);
                HideSubMenu(pnlThongKe);
            }
            else if (button.Equals(btnThongKe))
            {
                panel.Visible = true;
                HideSubMenu(pnlQLNhanSu);
                HideSubMenu(pnlChamCong);
                HideSubMenu(pnlTinhLuong);
            }
            else
            {
                HideSubMenu(pnlQLNhanSu);
                HideSubMenu(pnlChamCong);
                HideSubMenu(pnlTinhLuong);
                HideSubMenu(pnlThongKe);
            }

        }

        private void FocusButton(Button button)
        {

            button.BackColor = (Color)Constant.Colors["btnFocus"];
            foreach(Control control in pnlMenu.Controls)
            {
                if (control is Button && !control.Equals(button) 
                    && control.BackColor.Equals(Constant.Colors["btnFocus"]))
                {
                    control.BackColor = (Color)Constant.Colors["primary"];
                    break;
                }
            }
        }

        private void FocusSubButton(Button button, Panel panel)
        {
            button.BackColor = (Color)Constant.Colors["btnSubFocus"];
            foreach (Control control in panel.Controls)
            {
                if (control is Button && !control.Equals(button) 
                    && control.BackColor.Equals(Constant.Colors["btnSubFocus"]))
                {
                    control.BackColor = (Color)Constant.Colors["btnSub"];
                }
            }
        }

        #endregion

        #region Event

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

        private void btnQLNhanSu_Click(object sender, EventArgs e)
        {
            ShowSubMenu(btnQLNhanSu, pnlQLNhanSu);
        }

        private void btnTinhLuong_Click(object sender, EventArgs e)
        {
            ShowSubMenu(btnTinhLuong, pnlTinhLuong);
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            ShowSubMenu(btnThongKe, pnlThongKe);
        }

        private void btnChamCong_Click(object sender, EventArgs e)
        {
            ShowSubMenu(btnChamCong, pnlChamCong);
        }

        private void btnTongQuan_Click(object sender, EventArgs e)
        {
            ShowSubMenu(btnTongQuan, pnlSeperate);
        }

        private void btnQLPhongBan_Click(object sender, EventArgs e)
        {
            ShowSubMenu(btnQLPhongBan, pnlSeperate);
        }

        #endregion
    }
}
