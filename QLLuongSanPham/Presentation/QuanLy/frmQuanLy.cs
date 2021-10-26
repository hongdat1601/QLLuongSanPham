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
        #endregion

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            FocusBtn(btnThongKe);
            ToggleMenu(pnlThongKe);
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            FocusBtn(btnCapNhat);
            ToggleMenu(pnlCapNhat);
        }

        private void btnXuLy_Click(object sender, EventArgs e)
        {
            FocusBtn(btnXuLy);
            ToggleMenu(pnlXuLy);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            FocusBtn(btnTimKiem);
            ToggleMenu(pnlTimKiem);
        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            FocusBtn(btnDanhMuc);
            ToggleMenu(pnlDanhMuc);
        }
    }
}
