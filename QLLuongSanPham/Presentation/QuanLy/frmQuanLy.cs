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

        public frmQuanLy()
        {
            InitializeComponent();
        }


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

        #endregion

        private void frmQuanLy_Load(object sender, EventArgs e)
        {
            OpenFormChild(new frmTongQuan());
        }
    }
}
