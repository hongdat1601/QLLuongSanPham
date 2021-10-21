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
        public frmQuanLy()
        {
            InitializeComponent();
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
    }
}
